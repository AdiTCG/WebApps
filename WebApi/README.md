## WebApi
Created a Asp.net application with MVC and WebApi options checked. https://github.com/AdiTCG/WebApps/commit/cfd203f515ccb40309f5486de86a7e8d54363177
Added a class and implement ApiController. https://github.com/AdiTCG/WebApps/commit/7d6116dbf1c1505dc0eb01b596514307e8787ae6
Modified default url for methods https://github.com/AdiTCG/WebApps/commit/c0f7702205d91c4c8113d470e203a7fbaa117da9

## SQL DataBase connection
 
Models:
```
    public class Student
    {
        public string Name { get; set; }
        public int Roll { get; set; }
    }
```

```
public class Department
{
    public int Id { get; set; }
    public string Hod { get; set; }
    public List<Student> Students { get; }
}
```
## DataAccessor
This project has reference of Entity framework.
This will have a class inheriting dbContext. The class is responsible to track all the changes referred in it.