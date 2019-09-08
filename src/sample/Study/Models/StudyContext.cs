using Microsoft.EntityFrameworkCore;

namespace Study.Models{
  public class StudyContext : DbContext{
    public StudyContext (DbContextOptions<StudyContext> options) : base(options) {
    }

    public DbSet<Chat> Chats { get; set; }
  }
}