

// ReSharper disable CollectionNeverUpdated.Global

namespace CrawlerDbModels;

public sealed class HostModel
{
    public int HostId { get; set; }
    public required string HostName { get; set; }
    public bool HostProhibited { get; set; }

    public ICollection<UrlModel> Urls { get; set; } = new HashSet<UrlModel>();
    public ICollection<HostByBatch> HostsByBatches { get; set; } = new HashSet<HostByBatch>();
    public ICollection<Robot> Robots { get; set; } = new HashSet<Robot>();
}
