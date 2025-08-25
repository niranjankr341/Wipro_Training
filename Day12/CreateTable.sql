CREATE TABLE Students(
  Id INT PRIMARY KEY,
  Name VARCHAR(50),
  Age INT CHECK (Age >= 18)
);
