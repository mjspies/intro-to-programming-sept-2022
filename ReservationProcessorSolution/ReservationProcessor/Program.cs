/*
* We will ask the user for their:
* Email Address
* The ID of the course they'd like to take.
* The ID of the offering of that course they'd like to take.
*
* We will return to them:
* (Happy Path): A message that says their are registered, and a registration ID, and the date of the course.
* (Error): A message that says they cannot enroll for the course, and reason.
*/
//Console.WriteLine("register for a course");

//Console.Write("enter your email: ");
//string? email = Console.ReadLine();

//Console.Write("enter the course id: ");
//string? courseId = Console.ReadLine();

//Console.Write("enter the course offering id: ");
//string? courseOfferingId = Console.ReadLine();

//Console.WriteLine($"I see you are {email}, want to take {courseId} of {courseOfferingId}");

////wtcywyh - write the code you wish you had
//CourseRegistrationManager courseRegistrationManager = new CourseRegistrationManager();
//CourseRegistrationResponse response
//    = courseRegistrationManager.RegisterForCourse(email, courseId, courseOfferingId);

//if(response.isRegistered)
//{
//    Console.WriteLine("Congratulations! You have been registered!");
//    Console.WriteLine($"your registration id is {response.Id}");
//    Console.WriteLine($"The course starts on {response.courseDate:d}");
//}
//else
//{
//    Console.WriteLine("sorry, you are not registed for the course!");
//}
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder();

builder.Services.AddScoped<CourseRegistrationManager>();

var app = builder.Build();

app.MapPost("/registrations", (
    [FromBody] CourseRegistrationRequest request,
    [FromServices] CourseRegistrationManager manager) =>
{
    var response = manager.RegisterForCourse(request);
    if (response.IsRegistered)
    {
        return Results.Ok(response);
    }
    else
    {
        return Results.BadRequest(response);
    }
});


Console.WriteLine("Fixing to run your web application!");
app.Run();
Console.WriteLine("Done running your web application!");

