# CDA_2503
 
```docker
# https://geshan.com.np/blog/2023/03/mongodb-docker-compose/

docker pull mongodb/mongodb-community-server:8.2.5
docker run --name mongodb2503 -p 27017:27017 -d mongodb/mongodb-community-server:8.2.5
```


```yml
name: achat-mongodb
services:
  db:
    image: mongodb/mongodb-community-server:8.2.5-ubuntu2204
    container_name: MongoDB-Achat
    environment:
    #  - MONGODB_INITDB_ROOT_USERNAME=admin
    #  - MONGODB_INITDB_ROOT_PASSWORD=1234
      - MONGO_INITDB_DATABASE=Achat
    volumes:
      - Achatdb:/data/db
      - Achatdbconfigdb:/data/configdb
    ports:
      - "9002:27017"

volumes:
  Achatdb:
  Achatdbconfigdb:
```

Créer projet ASPNET CORE API Web

Créer un Modèle

```csharp
// Models/Achat.cs

public class Achat
{
    [BsonId]
    public int Id { get; set; }

    public string Nom { get; set; }

    public DateTime Date { get; set; }

    public decimal Montant { get; set; }

    public string CodePostal { get; set; }
}
```

Configurer la base de données :


/appsettings.json

```json
{
  "AchatDatabase": {
    "ConnectionString": "mongodb://localhost:9002",
    "DatabaseName": "Achat",
    "AchatCollectionName": "items"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```

Créer le  modèle de configuration (dans le répertoire Models)

```csharp
// Models/AchatDatabaseSettings.cs

public class AchatDatabaseSettings
{
    public string ConnectionString { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;

    public string AchatCollectionName { get; set; } = null!;
}
```

Créer le service CRUD (dans un dossier "Services" ^^)

```csharp
// Services/AchatService.cs

public class AchatService
{
    private readonly IMongoCollection<Achat> _achatCollection;

    public AchatService(
        IOptions<AchatDatabaseSettings> achatDatabaseSettings)
    {
        var mongoClient = new MongoClient(
            achatDatabaseSettings.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(
            achatDatabaseSettings.Value.DatabaseName);

        _achatCollection = mongoDatabase.GetCollection<Achat>(
            achatDatabaseSettings.Value.AchatCollectionName);
    }

    public async Task<List<Achat>> GetAsync() =>
        await _achatCollection.Find(_ => true).ToListAsync();

    public async Task<Achat?> GetAsync(string id) =>
        await _achatCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

    public async Task CreateAsync(Achat newAchat) =>
        await _achatCollection.InsertOneAsync(newAchat);

    public async Task UpdateAsync(string id, Achat updatedAchat) =>
        await _achatCollection.ReplaceOneAsync(x => x.Id == id, updatedAchat);

    public async Task RemoveAsync(string id) =>
        await _achatCollection.DeleteOneAsync(x => x.Id == id);
}
```


Créer le contrôleur

```csharp
// Controllers/AchatController.cs

[ApiController]
[Route("api/[controller]")]
public class AchatController : ControllerBase
{
    private readonly AchatService _achatService;

    public AchatController(AchatService achatService) =>
        _achatService = achatService;

    [HttpGet]
    public async Task<List<Achat>> Get() =>
        await _achatService.GetAsync();

    [HttpGet("{id:length(24)}")]
    public async Task<ActionResult<Achat>> Get(string id)
    {
        var achat = await _achatService.GetAsync(id);

        if (achat is null)
        {
            return NotFound();
        }

        return achat;
    }

    [HttpPost]
    public async Task<IActionResult> Post(Achat newAchat)
    {
        await _achatService.CreateAsync(newAchat);

        return CreatedAtAction(nameof(Get), new { id = newAchat.Id }, newAchat);
    }

    [HttpPut("{id:length(24)}")]
    public async Task<IActionResult> Update(string id, Achat updatedAchat)
    {
        var achat = await _achatService.GetAsync(id);

        if (achat is null)
        {
            return NotFound();
        }

        updatedAchat.Id = achat.Id;

        await _achatService.UpdateAsync(id, updatedAchat);

        return NoContent();
    }

    [HttpDelete("{id:length(24)}")]
    public async Task<IActionResult> Delete(string id)
    {
        var achat = await _achatService.GetAsync(id);

        if (achat is null)
        {
            return NotFound();
        }

        await _achatService.RemoveAsync(id);

        return NoContent();
    }
}
```

Référencer l'accès à la base de données et le service dans Program.cs

```csharp
// /Program.cs

// Add services to the container.
builder.Services.Configure<AchatDatabaseSettings>(
    builder.Configuration.GetSection("AchatDatabase"));

builder.Services.AddSingleton<AchatService>();

builder.Services.AddControllers()
    .AddJsonOptions(
        options => options.JsonSerializerOptions.PropertyNamingPolicy = null);
```