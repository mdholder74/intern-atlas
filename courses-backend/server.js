const express = require("express"); // Express framework for building web servers
const cors = require("cors"); // Middleware to enable Cross-Origin Resource Sharing. Allows the server to accept requests from different origins like a frontend application as Angular or React..
const fs = require("fs"); // File system module for reading/writing files
const path = require("path"); // Utility for helping build paths in a safe way across different operating systems

const app = express(); // Create an Express application instance
app.use(cors()); // Enable CORS for all routes
app.use(express.json()); // Parse incoming JSON requests

// Absoulte Path to our JSON database
const DB_FILE = path.join(__dirname, "db.json"); // It gives you the absolute path to the directory where the current file (your server file) lives. Example: If your file is in /Users/moe/server/index.js, then __dirname is /Users/moe/server.

// Helper function to load data
function loadData() {
  const dataBuffer = fs.readFileSync(DB_FILE); //Reads the contents of db.json
  return JSON.parse(dataBuffer.toString()); // Converts the buffer to a string and then parses it as JSON
}

// Helper function to save data
function saveData(data) {
  // Convert the data object to a JSON string and write it to the db.json file.
  // If the file does not exist, it will be created. If it exists, it will be overwritten.
  // The first argument is the file path, which is DB_FILE. The second argument 'null' is for the replacer function, which we don't need. The third argument '2' is for pretty-printing the JSON with an indentation of 2 spaces.
  fs.writeFileSync(DB_FILE, JSON.stringify(data, null, 2));
}

// Route to get all courses
app.get("/courses", (req, res) => {
  try {
    const data = loadData(); // Load the data from the JSON file
    let courses = data.courses; // Extract the courses array from the data

    const descriptionFilter = req.query.description; // Get the 'description' query parameter from the request
    if (descriptionFilter) {
      // If a description filter is provided, filter the courses based on the description
      courses = courses.filter((course) =>
        course.description
          .toLowerCase()
          .includes(descriptionFilter.toLowerCase())
      );
    }
    res.json(courses); // Send the filtered courses as a JSON response
  } catch (error) {
    console.error("Error loading courses:", error); // Log the error to the console
    res.status(500).json({ error: "Failed to load courses" }); // Send a 500 Internal Server Error response
  }
});

// Route to get a course by ID
app.get("/courses/:id", (req, res) => {
  const courseId = parseInt(req.params.id, 10); // Parse the course ID from the request parameters
  try {
    const data = loadData(); // Load the data from the JSON file
    const course = data.courses.find(
      (courseItem) => courseItem.id === courseId
    ); // Find the course with the matching ID
    if (course) {
      res.json(course); // If found, send the course as a JSON response
    }
  } catch (error) {
    console.error("Error loading course:", error); // Log the error to the console
    res.status(500).json({ error: "Failed to load course" }); // Send a 500 Internal Server Error response
  }
});

// Route to add a new course
app.post("/courses", (req, res) => {
  const newCourse = req.body; // Get the new course data from the request body
  try {
    const data = loadData(); // Load the existing data from the JSON file
    newCourse.id = Date.now(); // Assign a new ID to the course
    data.courses.push(newCourse); // Add the new course to the courses array
    saveData(data); // Save the updated data back to the JSON file
    res.status(201).json(newCourse); // Send a 201 Created response with the new course
  } catch (error) {
    console.error("Error adding course:", error);
    res.status(500).json({ error: "Failed to add course" }); // Send a 500 Internal Server Error response
  }
});

// Get all users
app.get("/users", (req, res) => {
  const data = loadData();
  res.json(data.users);
});

// Add a new user
app.post("/users", (req, res) => {
  const data = loadData();
  const newuser = req.body;
  // Simple ID generation
  newuser.id = Date.now();
  data.users.push(newuser);
  saveData(data);
  res.status(201).json(newuser);
});

// Add a course to a user's enrolledCourses
app.post("/users/:userId/courses", (req, res) => {
  const data = loadData();
  const userId = parseInt(req.params.userId, 10);
  const user = data.users.find((s) => s.id === userId);

  if (!user) {
    return res.status(404).json({ error: "user not found" });
  }

  const { courseId } = req.body;
  // Check if the course exists
  const courseExists = data.courses.some((c) => c.id === courseId);
  if (!courseExists) {
    return res.status(404).json({ error: "Course not found" });
  }

  // Add courseId to enrolledCourses if not already there
  if (!user.enrolledCourses.includes(courseId)) {
    user.enrolledCourses.push(courseId);
    saveData(data);
  }

  res.status(200).json(user);
});

// Get all users for a given course
app.get("/courses/:id/users", (req, res) => {
  const data = loadData();
  const courseId = parseInt(req.params.id, 10);

  const enrolledusers = data.users.filter(
    (user) => user.enrolledCourses && user.enrolledCourses.includes(courseId)
  );

  res.json(enrolledusers);
});

app.get("/agileEvents", (req, res) => {
  try {
    const data = loadData(); // Load the data from the JSON file
    res.json(data.agileEvents); // Send the agileEvents array as a JSON response
  } catch (error) {
    console.error("Error loading agile events:", error); // Log the error to the console
    res.status(500).json({ error: "Failed to load agile events" }); // Send a 500 Internal Server Error response
  }
});

app.get("/azureStages", (req, res) => {
  try {
    const data = loadData(); // Load the data from the JSON file
    res.json(data.azureStages); // Send the azureStages array as a JSON response
  } catch (error) {
    console.error("Error loading azure stages:", error); // Log the error to the console
    res.status(500).json({ error: "Failed to load azure stages" }); // Send a 500 Internal Server Error response
  }
});

// Start the server
const PORT = 3000;
app.listen(PORT, () => {
  console.log(`Server running on http://localhost:${PORT}`);
});
