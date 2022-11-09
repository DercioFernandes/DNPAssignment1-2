namespace Domain.DTOs;

public class PostDetailDTO
{
    public int Id { get; }
    public int? OwnerId { get; set; }
    public string? Title { get; set; }
    public bool? description { get; set; }

    public PostDetailDTO(int id)
    {
        Id = id;
    }
}