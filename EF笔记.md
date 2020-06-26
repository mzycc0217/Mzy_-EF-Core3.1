
都是在有Context的库中安装，继承DbContext

 public class DemoContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Demp;uid=sa;pwd=123456");
        }
        public DbSet<League> leagues { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Player> Players { get; set; }
    }










获取迁移数据库命令

 Add-Migration               Adds a new migration.: 添加一个迁移文件  后面可以带参数
 Update-Database             Updates the database to a specified migration：执行更新数据库   

如果报错以上内容添加以下库

 Script-Migration            Generates a SQL script from migrations.生成一个迁移脚本

 Update-Database -verbose 查看生成数据哭的明细，在生产环境中使用

如果对orm进行了修改那么就使用以下命令修改
