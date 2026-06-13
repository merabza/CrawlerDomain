

// ReSharper disable CollectionNeverUpdated.Global

namespace CrawlerDbModels;

public sealed class TermType
{
    public int TtId { get; set; }
    public required string TtKey { get; set; }
    public string? TtName { get; set; }

    public ICollection<Term> Terms { get; set; } = new HashSet<Term>();
}
