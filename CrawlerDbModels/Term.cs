

// ReSharper disable CollectionNeverUpdated.Global

namespace CrawlerDbModels;

public sealed class Term
{
    private TermType? _termTypeNavigation;

    public int TrmId { get; set; }
    public required string TermText { get; set; }
    public int TermTypeId { get; set; }

    public TermType TermTypeNavigation
    {
        get =>
            _termTypeNavigation ??
            throw new InvalidOperationException("Uninitialized property: " + nameof(TermTypeNavigation));
        set => _termTypeNavigation = value;
    }

    public ICollection<TermByUrl> TermsByUrls { get; set; } = new HashSet<TermByUrl>();
}
