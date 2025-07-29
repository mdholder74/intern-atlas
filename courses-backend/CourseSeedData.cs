modelBuilder.Entity<Course>().HasData(new Course {
        Id = 1,
        Title = "Installation and Setup",
        Description = " This course guides you through the essential setup steps and introduces the core concepts",
        Duration = "3 hours",
        Difficulty = "Easy,☕ Coffee’s Still Hot ",
        PersonalNotesUrl = "https://example.com/personal-notes",
        OfficialDocsUrl = "https://angular.dev/installation",
        LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
        Review = "Great course! Clear explanations and practical examples. Helped me understand how Signals differ from RxJS.",
        Tags = new List<string> { "angular", "setup", "cli", "environment" },
        CodeSnippet = "ng new angular-app-name --routing",
        Img = "favicon.ico"
    });

modelBuilder.Entity<Course>().HasData(new Course {
        Id = 2,
        Title = "Traditional Components",
        Description = "Discover how traditional Angular components shape your application's user interface.",
        Duration = "1 hour",
        Difficulty = "Medium, 😅 Coffee’s Lukewarm ",
        PersonalNotesUrl = "https://example.com/personal-notes",
        OfficialDocsUrl = "https://angular.dev/guide/components",
        LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
        Review = "Solid breakdown of component architecture. Loved the examples and visual explanations.",
        Tags = new List<string> { "angular", "components", "architecture" },
        CodeSnippet = "ng new angular-app-name --no-standalone",
        Img = "favicon.ico"
    });

modelBuilder.Entity<Course>().HasData(new Course
{
    Id = 3,
    Title = "Standalone Components",
    Description = "Learn how standalone components simplify Angular development by removing the need for NgModules.",
    Duration = "3 hours",
    Difficulty = "Medium, 😅 Coffee’s Lukewarm ",
    PersonalNotesUrl = "https://pulte-my.sharepoint.com/:w:/p/maholder/EbWVAQEt6clNg4FOj6DjT_0BE1hzYFiW496P2kDFuQyQ2A?e=pEBArL",
    OfficialDocsUrl = "https://angular.dev/guide/ngmodules/overview",
    LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
    Review = "Helped me understand when to use standalone components and how they simplify module management.",
    Tags = new List<string> { "angular", "standalone", "modules" },
    CodeSnippet = "ng new angular-app-name --routing",
    Img = "favicon.ico"
});

modelBuilder.Entity<Course>().HasData(new Course
{
    Id = 4,
    Title = "Binding",
    Description = "Dive into data binding in Angular and learn how it connects your application's logic to the user interface.",
    Duration = "10 hours",
    Difficulty = "Medium, 😅 Coffee’s Lukewarm",
    PersonalNotesUrl = "https://pulte-my.sharepoint.com/:w:/p/maholder/ERt6Sa8K_hlPvgT7x-qexNYB2ElfrdJOdat1LjY0x7C7aA?e=9bWr4q",
    OfficialDocsUrl = "https://angular.dev/guide/templates/binding",
    LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
    Review = "Covers all titles of binding clearly—property, event, and two-way.",
    Tags = new List<string> { "angular", "binding", "data" },
    CodeSnippet = "<[src]=\"imageUrl\" (click)=\"onClick()\">",
    Img = "favicon.ico"
});

modelBuilder.Entity<Course>().HasData(new Course
{
    Id = 5,
    Title = "Dependency Injection",
    Description = "Explore how Angular’s dependency injection system simplifies code management and promotes modular design.",
    Duration = "7 hours",
    Difficulty = "Hard, 🔥 Coffee’s Cold & You’re Debugging",
    PersonalNotesUrl = "https://pulte-my.sharepoint.com/:w:/p/maholder/EX7sZfCwHQhKnzIN-97M7JoBxNImanMiF17J-0QaeRYpOA?e=gmr2Aj",
    OfficialDocsUrl = "https://angular.dev/guide/di",
    LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
    Review = "DI is powerful once you understand providers and injectors.",
    Tags = new List<string> { "angular", "di", "services" },
    CodeSnippet = "constructor(private http: HttpClient) {}",
    Img = "favicon.ico"
});

modelBuilder.Entity<Course>().HasData(new Course
{
    Id = 6,
    Title = "Observables",
    Description = "You'll learn how Observables work under the hood, how to create and subscribe to them, and how they integrate with Angular services and HTTP requests. ",
    Duration = "8 hours",
    Difficulty = "Medium, 😅 Coffee’s Lukewarm",
    PersonalNotesUrl = "https://pulte-my.sharepoint.com/:w:/p/maholder/EaWGsN0Y82NMjdUKk2PvuewBTytPCXvtZJPSI5GRUoPnRQ?e=D7ieSK",
    OfficialDocsUrl = "https://angular.dev/guide/http/making-requests#http-observables",
    LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
    Review = "This course provides a solid foundation in using Observables within Angular. The explanations are clear, and the examples are practical, especially the sections on HTTP requests and reactive forms. ",
    Tags = new List<string> { "angular", "observables", "architecture" },
    CodeSnippet = "getCourses(): Observable<Course[]> {}",
    Img = "favicon.ico"
});

modelBuilder.Entity<Course>().HasData(new Course
{
    Id = 7,
    Title = "Interface",
    Description = "Understand how interfaces in Angular help define the shape of data and enforce title safety. .",
    Duration = "1 hour",
    Difficulty = "Easy, ☕ Coffee’s Still Hot!",
    PersonalNotesUrl = "https://pulte-my.sharepoint.com/:w:/p/maholder/Ef0L5QPwdIhDh6O5mwUsDT8BSFd4XixbgPtUKibjGv6YMg?e=YWEdca",
    OfficialDocsUrl = "https://www.titlescriptlang.org/docs/handbook/interfaces.html",
    LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
    Review = "Interfaces help enforce structure and improve title safety.",
    Tags = new List<string> { "titlescript", "interfaces", "typing" },
    CodeSnippet = "interface Course { title: string; duration: string; }",
    Img = "favicon.ico"
});

modelBuilder.Entity<Course>().HasData(new Course
{
    Id = 8,
    Title = "Routing and Navigation",
    Description = "Master Angular’s routing and navigation system to build seamless, single-page applications..",
    Duration = "10 hours",
    Difficulty = "Hard, 🔥 Coffee’s Cold & You’re Debugging",
    PersonalNotesUrl = "https://pulte-my.sharepoint.com/:w:/p/maholder/EWk_eXAQUxNCu0mquUqx55UBqCQ3vdI9djOP5M6bYrzy5A?e=Qtci4r",
    OfficialDocsUrl = "https://angular.dev/guide/routing",
    LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
    Review = "Routing was tricky at first, but guards and lazy loading made it click.",
    Tags = new List<string> { "angular", "routing", "navigation" },
    CodeSnippet = "path: 'dashboard', component: DashboardComponent",
    Img = "favicon.ico"
});

modelBuilder.Entity<Course>().HasData(new Course
{
    Id = 9,
    Title = "Reactive Forms",
    Description = "Gain a deep understanding of reactive forms in Angular and how they enable dynamic, scalable form handling.",
    Duration = "5 hours",
    Difficulty = "Hard, 🔥 Coffee’s Cold & You’re Debugging",
    PersonalNotesUrl = "https://pulte-my.sharepoint.com/:w:/p/maholder/ETMwO2Wy501MooBVP2HgDm0Bs_q0p04aMtYoSMOgfzcQXg?e=3irLJZ",
    OfficialDocsUrl = "https://angular.dev/guide/forms",
    LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
    Review = "Reactive forms are powerful for validation and dynamic controls.",
    Tags = new List<string> { "angular", "forms", "reactive" },
    CodeSnippet = "this.form = new FormGroup({ name: new FormControl('') });",
    Img = "favicon.ico"
});

modelBuilder.Entity<Course>().HasData(new Course
{
    Id = 10,
    Title = "RxJS Operators",
    Description = "Unlock the power of RxJS operators to transform, filter, and manage streams of data in Angular.",
    Duration = "9 hours",
    Difficulty = "Hard, 🔥 Coffee’s Cold & You’re Debugging",
    PersonalNotesUrl = "https://pulte-my.sharepoint.com/:w:/p/maholder/EUlGHXl5Hr1MpAv71ozZHPkBNZOnoL424hzifdL9g-LDfg?e=tlyRkG",
    OfficialDocsUrl = "https://rxjs.dev/guide/operators",
    LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
    Review = "RxJS is a beast, but once you get map, mergeMap, and switchMap, it’s 🔥.",
    Tags = new List<string> { "rxjs", "observables", "operators" },
    CodeSnippet = "source$.pipe(map(val => val * 2))",
    Img = "favicon.ico"
});

modelBuilder.Entity<Course>().HasData(new Course
{
    Id = 11,
    Title = "Testing & Debugging",
    Description = "Learn how to write effective tests and debug Angular applications with confidence. .",
    Duration = "10 hours",
    Difficulty = "Hard, 🔥 Coffee’s Cold & You’re Debugging",
    PersonalNotesUrl = "https://pulte-my.sharepoint.com/:w:/p/maholder/ETb__BB221ZOtU4YlMOh2V0BE_cAZuJAaSHDKeP7jPQzEw?e=eLbKHK",
    OfficialDocsUrl = "https://angular.dev/guide/testing",
    LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
    Review = "Unit testing with Jasmine and Karma was easier than expected. Debugging tips were gold.",
    Tags = new List<string> { "angular", "testing", "debugging" },
    CodeSnippet = "expect(component.title).toEqual('MyApp')",
    Img = "favicon.ico"
});

modelBuilder.Entity<Course>().HasData(new Course
{
    Id = 12,
    Title = "Extras",
    Description = "Explore additional Angular features including working with images, creating and using pipes, and handling advanced syntax.",
    Duration = "2 hours",
    Difficulty = "Easy, ☕ Coffee’s Still Hot!",
    PersonalNotesUrl = "https://pulte-my.sharepoint.com/:w:/p/maholder/EQmlfz-xClhOjw6FhsdaT4ABswVDOw6XNIlYfdsLbvpZcA?e=aUS0Jk",
    OfficialDocsUrl = "https://angular.io/",
    LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
    Review = "A fun wrap-up of random but useful Angular tricks.",
    Tags = new List<string> { "angular", "extras", "tips" },
    CodeSnippet = "<img [src]=\"imageUrl\"> {{ birthday | date:'longDate' }}",
    Img = "favicon.ico"
});

/*
Program.cs
using LearningLog.API.DbContexts;
using LearningLog.API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();// registers services needed for APIs
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// It registers the specified DbContext (in this case, CourseInfoContext) with the dependency injection container.
// This allows the framework to create and manage instances of CourseInfoContext automatically.
// - A new instance is created per HTTP request - The same instance is reused throughout that request.
// 'UseSqlite' is an extension method. It helps connect to a SQLite database.
builder.Services.AddDbContext<CourseInfoContext>(dbContextOptions =>
    dbContextOptions.UseSqlite(
        builder.Configuration["ConnectionStrings:CourseInfoDBConnectionString"]));

builder.Services.AddScoped<ICourseInfoRepository, CourseInfoRepositoryn>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())// Checks if we are running in the development env instead or prod or stage
{
    app.UseSwagger();//middleware
    app.UseSwaggerUI();//middleware
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();

*/

/*
Controllers
CourseController.cs
using AutoMapper;
using LearningLog.API.Models; // Make sure this matches the namespace where your Course model is defined
using LearningLog.API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks; // Needed for IEnumerable

namespace LearningLog.API.Controllers
{
    [ApiController]// Marks the class as a Web API controller, enabling automatic request binding, model validation, and standardized error responses
    [Route("api/courses")]// Defines the base URL route for your controller. Uses a placeholder [controller] that automatically gets replaced with the controller's class name 
    public class CourseController : ControllerBase// Inherits from ControllerBase to create a Web API controller without view support (for APIs only)
    {
        private readonly ICourseInfoRepository _courseInfoRepository;
        private readonly IMapper _mapper;

        public CourseController(ICourseInfoRepository courseInfoRepository, IMapper mapper) 
        {
            _courseInfoRepository = courseInfoRepository ?? 
                throw new ArgumentNullException(nameof(courseInfoRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        // GET: api/courses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CourseDto>>> GetCourses()
        {
            var courseEntities = await _courseInfoRepository.GetCoursesAsync();
            return Ok(_mapper.Map<IEnumerable<CourseDto>>(courseEntities));
        }

        // GET: api/courses/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<CourseDto>> GetCourse(int id)
        {
            var course = await _courseInfoRepository.GetCourseAsync(id);
            if (course == null)
            {
                return NotFound();
            }

            return Ok();
        }

        // POST: api/courses
        [HttpPost]
        public ActionResult<CourseDto> CreateCourse([FromBody] CourseDto newCourse)
        {
            try
            {
                // Replace this with your actual data storage logic
                // For now, just return the course as if it was saved
                return CreatedAtAction(nameof(GetCourse), new { id = newCourse.Id }, newCourse);
            }
            catch
            {
                return StatusCode(500, "An error occurred while creating the course.");
            }
        }
    }
}

*/

/*
DbContexts
CourseInfoContext.cs
using LearningLog.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace LearningLog.API.DbContexts
{
    // This class represents the database context for your application.
    // It manages the connection to the database and provides access to your tables (DbSets).
    public class CourseInfoContext : DbContext
    {
        // Constructor that allows dependency injection of DbContextOptions
        // It takes a parameter 'options' of type DbContextOptions<CourseInfoContext>,
        // which contains configuration information for the database context
        // The base(options) call passes the configuration options to the base class (DbContext).
        // This allows Entity Framework to know how to connect to the database,
        // what provider to use (e.g., SQL Server, SQLite), and other settings.


        public CourseInfoContext(DbContextOptions<CourseInfoContext> options)
                : base(options)
            {
            }

        // This method is called when the model for a derived context is being created.
        // It allows you to configure the model and relationships between entities.
        // By calling base.OnModelCreating(modelBuilder);, it ensures that any configuration defined in the base DbContext is applied.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 1,
                Title = "Installation and Setup",
                Description = " This course guides you through the essential setup steps and introduces the core concepts",
                Duration = "3 hours",
                Difficulty = "Easy,☕ Coffee’s Still Hot ",
                PersonalNotesUrl = "https://example.com/personal-notes",
                OfficialDocsUrl = "https://angular.dev/installation",
                LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
                Review = "Great course! Clear explanations and practical examples. Helped me understand how Signals differ from RxJS.",
                Tags = new List<string> { "angular", "setup", "cli", "environment" },
                CodeSnippet = "ng new angular-app-name --routing",
                Img = "favicon.ico"
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 2,
                Title = "Traditional Components",
                Description = "Discover how traditional Angular components shape your application's user interface.",
                Duration = "1 hour",
                Difficulty = "Medium, 😅 Coffee’s Lukewarm ",
                PersonalNotesUrl = "https://example.com/personal-notes",
                OfficialDocsUrl = "https://angular.dev/guide/components",
                LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
                Review = "Solid breakdown of component architecture. Loved the examples and visual explanations.",
                Tags = new List<string> { "angular", "components", "architecture" },
                CodeSnippet = "ng new angular-app-name --no-standalone",
                Img = "favicon.ico"
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 3,
                Title = "Standalone Components",
                Description = "Learn how standalone components simplify Angular development by removing the need for NgModules.",
                Duration = "3 hours",
                Difficulty = "Medium, 😅 Coffee’s Lukewarm ",
                PersonalNotesUrl = "https://pulte-my.sharepoint.com/:w:/p/maholder/EbWVAQEt6clNg4FOj6DjT_0BE1hzYFiW496P2kDFuQyQ2A?e=pEBArL",
                OfficialDocsUrl = "https://angular.dev/guide/ngmodules/overview",
                LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
                Review = "Helped me understand when to use standalone components and how they simplify module management.",
                Tags = new List<string> { "angular", "standalone", "modules" },
                CodeSnippet = "ng new angular-app-name --routing",
                Img = "favicon.ico"
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 4,
                Title = "Binding",
                Description = "Dive into data binding in Angular and learn how it connects your application's logic to the user interface.",
                Duration = "10 hours",
                Difficulty = "Medium, 😅 Coffee’s Lukewarm",
                PersonalNotesUrl = "https://pulte-my.sharepoint.com/:w:/p/maholder/ERt6Sa8K_hlPvgT7x-qexNYB2ElfrdJOdat1LjY0x7C7aA?e=9bWr4q",
                OfficialDocsUrl = "https://angular.dev/guide/templates/binding",
                LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
                Review = "Covers all titles of binding clearly—property, event, and two-way.",
                Tags = new List<string> { "angular", "binding", "data" },
                CodeSnippet = "<[src]=\"imageUrl\" (click)=\"onClick()\">",
                Img = "favicon.ico"
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 5,
                Title = "Dependency Injection",
                Description = "Explore how Angular’s dependency injection system simplifies code management and promotes modular design.",
                Duration = "7 hours",
                Difficulty = "Hard, 🔥 Coffee’s Cold & You’re Debugging",
                PersonalNotesUrl = "https://pulte-my.sharepoint.com/:w:/p/maholder/EX7sZfCwHQhKnzIN-97M7JoBxNImanMiF17J-0QaeRYpOA?e=gmr2Aj",
                OfficialDocsUrl = "https://angular.dev/guide/di",
                LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
                Review = "DI is powerful once you understand providers and injectors.",
                Tags = new List<string> { "angular", "di", "services" },
                CodeSnippet = "constructor(private http: HttpClient) {}",
                Img = "favicon.ico"
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 6,
                Title = "Observables",
                Description = "You'll learn how Observables work under the hood, how to create and subscribe to them, and how they integrate with Angular services and HTTP requests. ",
                Duration = "8 hours",
                Difficulty = "Medium, 😅 Coffee’s Lukewarm",
                PersonalNotesUrl = "https://pulte-my.sharepoint.com/:w:/p/maholder/EaWGsN0Y82NMjdUKk2PvuewBTytPCXvtZJPSI5GRUoPnRQ?e=D7ieSK",
                OfficialDocsUrl = "https://angular.dev/guide/http/making-requests#http-observables",
                LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
                Review = "This course provides a solid foundation in using Observables within Angular. The explanations are clear, and the examples are practical, especially the sections on HTTP requests and reactive forms. ",
                Tags = new List<string> { "angular", "observables", "architecture" },
                CodeSnippet = "getCourses(): Observable<Course[]> {}",
                Img = "favicon.ico"
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 7,
                Title = "Interface",
                Description = "Understand how interfaces in Angular help define the shape of data and enforce title safety. .",
                Duration = "1 hour",
                Difficulty = "Easy, ☕ Coffee’s Still Hot!",
                PersonalNotesUrl = "https://pulte-my.sharepoint.com/:w:/p/maholder/Ef0L5QPwdIhDh6O5mwUsDT8BSFd4XixbgPtUKibjGv6YMg?e=YWEdca",
                OfficialDocsUrl = "https://www.titlescriptlang.org/docs/handbook/interfaces.html",
                LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
                Review = "Interfaces help enforce structure and improve title safety.",
                Tags = new List<string> { "titlescript", "interfaces", "typing" },
                CodeSnippet = "interface Course { title: string; duration: string; }",
                Img = "favicon.ico"
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 8,
                Title = "Routing and Navigation",
                Description = "Master Angular’s routing and navigation system to build seamless, single-page applications..",
                Duration = "10 hours",
                Difficulty = "Hard, 🔥 Coffee’s Cold & You’re Debugging",
                PersonalNotesUrl = "https://pulte-my.sharepoint.com/:w:/p/maholder/EWk_eXAQUxNCu0mquUqx55UBqCQ3vdI9djOP5M6bYrzy5A?e=Qtci4r",
                OfficialDocsUrl = "https://angular.dev/guide/routing",
                LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
                Review = "Routing was tricky at first, but guards and lazy loading made it click.",
                Tags = new List<string> { "angular", "routing", "navigation" },
                CodeSnippet = "path: 'dashboard', component: DashboardComponent",
                Img = "favicon.ico"
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 9,
                Title = "Reactive Forms",
                Description = "Gain a deep understanding of reactive forms in Angular and how they enable dynamic, scalable form handling.",
                Duration = "5 hours",
                Difficulty = "Hard, 🔥 Coffee’s Cold & You’re Debugging",
                PersonalNotesUrl = "https://pulte-my.sharepoint.com/:w:/p/maholder/ETMwO2Wy501MooBVP2HgDm0Bs_q0p04aMtYoSMOgfzcQXg?e=3irLJZ",
                OfficialDocsUrl = "https://angular.dev/guide/forms",
                LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
                Review = "Reactive forms are powerful for validation and dynamic controls.",
                Tags = new List<string> { "angular", "forms", "reactive" },
                CodeSnippet = "this.form = new FormGroup({ name: new FormControl('') });",
                Img = "favicon.ico"
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 10,
                Title = "RxJS Operators",
                Description = "Unlock the power of RxJS operators to transform, filter, and manage streams of data in Angular.",
                Duration = "9 hours",
                Difficulty = "Hard, 🔥 Coffee’s Cold & You’re Debugging",
                PersonalNotesUrl = "https://pulte-my.sharepoint.com/:w:/p/maholder/EUlGHXl5Hr1MpAv71ozZHPkBNZOnoL424hzifdL9g-LDfg?e=tlyRkG",
                OfficialDocsUrl = "https://rxjs.dev/guide/operators",
                LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
                Review = "RxJS is a beast, but once you get map, mergeMap, and switchMap, it’s 🔥.",
                Tags = new List<string> { "rxjs", "observables", "operators" },
                CodeSnippet = "source$.pipe(map(val => val * 2))",
                Img = "favicon.ico"
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 11,
                Title = "Testing & Debugging",
                Description = "Learn how to write effective tests and debug Angular applications with confidence. .",
                Duration = "10 hours",
                Difficulty = "Hard, 🔥 Coffee’s Cold & You’re Debugging",
                PersonalNotesUrl = "https://pulte-my.sharepoint.com/:w:/p/maholder/ETb__BB221ZOtU4YlMOh2V0BE_cAZuJAaSHDKeP7jPQzEw?e=eLbKHK",
                OfficialDocsUrl = "https://angular.dev/guide/testing",
                LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
                Review = "Unit testing with Jasmine and Karma was easier than expected. Debugging tips were gold.",
                Tags = new List<string> { "angular", "testing", "debugging" },
                CodeSnippet = "expect(component.title).toEqual('MyApp')",
                Img = "favicon.ico"
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 12,
                Title = "Extras",
                Description = "Explore additional Angular features including working with images, creating and using pipes, and handling advanced syntax.",
                Duration = "2 hours",
                Difficulty = "Easy, ☕ Coffee’s Still Hot!",
                PersonalNotesUrl = "https://pulte-my.sharepoint.com/:w:/p/maholder/EQmlfz-xClhOjw6FhsdaT4ABswVDOw6XNIlYfdsLbvpZcA?e=aUS0Jk",
                OfficialDocsUrl = "https://angular.io/",
                LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
                Review = "A fun wrap-up of random but useful Angular tricks.",
                Tags = new List<string> { "angular", "extras", "tips" },
                CodeSnippet = "<img [src]=\"imageUrl\"> {{ birthday | date:'longDate' }}",
                Img = "favicon.ico"
            });

            base.OnModelCreating(modelBuilder);
        }

            // DbSet represents a table in the database.
            // This will create a "Courses" table based on your Course entity.
            public DbSet<Course> Courses { get; set; }

    }
}

*/

/*
Entities
Course.cs
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearningLog.API.Entities
{
    // Ensure the Course class has a parameterless constructor
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public string Difficulty { get; set; }
        public string PersonalNotesUrl { get; set; }
        public string OfficialDocsUrl { get; set; }
        public string LinkedInVideoUrl { get; set; }
        public string Review { get; set; }
        public List<string> Tags { get; set; }
        public string CodeSnippet { get; set; }
        public string Img { get; set; }

        // Add this parameterless constructor if it does not exist
        public Course()
        {
        }

    }
}

*/

/*
Models
CourseDto.cs
namespace LearningLog.API.Models
{
    public class CourseDto
    {

        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
        public string Difficulty { get; set; } = string.Empty;
        public string PersonalNotesUrl { get; set; } = string.Empty;
        public string OfficialDocsUrl { get; set; } = string.Empty;
        public string LinkedInVideoUrl { get; set; } = string.Empty;
        public string Review { get; set; } = string.Empty;
        public List<string> Tags { get; set; } = new List<string>();
        public string CodeSnippet { get; set; } = string.Empty;
        public string Img { get; set; } = string.Empty;
        public bool IsFavoritedByCurrentUser { get; set; }


    }
}

*/

/*
Profiles
CourseProfile.cs
using AutoMapper;

namespace LearningLog.API.Profiles
{
    public class CourseProfile : Profile
    {
        public CourseProfile() 
        {
            CreateMap<Entities.Course, Models.CourseDto>();//  maps configuration btw database entity and DTO. Handles property copuing automatically
        }
    }
}

*/

/*
Services
ICourseInfoRepository.cs
using LearningLog.API.Entities;

namespace LearningLog.API.Services
{
    public interface ICourseInfoRepository
    {
        Task<IEnumerable<Course>> GetCoursesAsync();
        Task<bool> CourseExistsAsync(int courseId);
        Task<Course?> GetCourseAsync(int courseId);
    }
}


*/

/*
Services
CourseInfoRepository.cs
using LearningLog.API.DbContexts;
using LearningLog.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace LearningLog.API.Services
{
    public class CourseInfoRepositoryn : ICourseInfoRepository
    {
        private readonly CourseInfoContext _context;

        public CourseInfoRepositoryn(CourseInfoContext context)
        {
            _context = context ?? throw new ArgumentException(nameof(context));
        }

        public async Task<IEnumerable<Course>> GetCoursesAsync()
        {
            return await _context.Courses.ToListAsync();
        }

        public async Task<Course?> GetCourseAsync(int courseId)
        {
            return await _context.Courses
                .Where(c => c.Id == courseId).FirstOrDefaultAsync();
        }
        public async Task<bool> CourseExistsAsync(int courseId)
        {
            return await _context.Courses.AnyAsync(c  => c.Id == courseId);
        }
    }
}

*/

/*
AppSettings
appsettings.Development.json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "LearningLog.API.Controllers": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "ConnectionStrings": {
    "CourseInfoDBConnectionString": "Data Source=CourseInfo.db"
  }
}

*/

/*
gitignore

## Ignore Visual Studio temporary files, build results, and
## files generated by popular Visual Studio add-ons.

# User-specific files
*.rsuser
*.suo
*.user
*.userosscache
*.sln.docstates

# User-specific files (MonoDevelop/Xamarin Studio)
*.userprefs

# Build results
[Dd]ebug/
[Rr]elease/
x64/
x86/
[Aa][Rr][Mm]/
bld/
[Bb]in/
[Oo]bj/

# Uncomment if you have tasks that create the project's static files in wwwroot
#wwwroot/

# Visual Studio working folder
.vs/

# Rider
.idea/

# ASP.NET Scaffolding
ScaffoldingReadMe.txt

# DotCover
*.dotCover

# Database files
*.db
*.db-shm
*.db-wal

# Others
*.log
*.tlog
*.cache
*.pdb
*.mdb
*.opendb
*.VC.db
*.vscode/

# LibMan
libman.json

# HTTP files
*.http

# Backup & Report files
*.bak
*.ncb
*.sdf
*.orig
_ReSharper*
*.[Rr]e[Ss]harper
*.DotSettings.user

# NuGet
*.nupkg
*.snupkg
.nuget/
project.lock.json
project.fragment.lock.json
artifacts/

# Windows image file caches
Thumbs.db
ehthumbs.db

# Folder config file
Desktop.ini

# Recycle Bin used on file shares
$RECYCLE.BIN/

# VS Code
.vscode/

# JetBrains Rider
.idea/
*.sln.iml


*/

