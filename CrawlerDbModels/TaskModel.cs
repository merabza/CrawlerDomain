// ReSharper disable CollectionNeverUpdated.Global

using SystemTools.SystemToolsShared;

namespace CrawlerDbModels;

public sealed class TaskModel : ItemData
{
    public int TaskId { get; set; }
    public required string TaskName { get; set; }
    public string? ApiName { get; set; }

    public ICollection<TaskStartPoint> StartPoints { get; set; } = new HashSet<TaskStartPoint>();
}
