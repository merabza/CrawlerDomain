

// ReSharper disable CollectionNeverUpdated.Global

namespace CrawlerDbModels;

public sealed class SchemeModel
{
    public int SchId { get; set; }
    public required string SchName { get; set; }
    public bool SchProhibited { get; set; }

    public ICollection<UrlModel> Urls { get; set; } = new HashSet<UrlModel>();
    public ICollection<HostByBatch> HostsByBatches { get; set; } = new HashSet<HostByBatch>();
    public ICollection<Robot> Robots { get; set; } = new HashSet<Robot>();
}
