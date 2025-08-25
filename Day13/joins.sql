SELECT s.Name, c.CourseName
FROM Students s
INNER JOIN Courses c ON s.CourseId = c.Id;
