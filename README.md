Advanced .NET

Assignment 1

============================================================


I deviated from the original assignment slightly:

* I thought it would be neat to try to follow northwood tech's email naming scheme, so I:
  * Implemented Student.Email's getter as a function, similar to the implementation of Student.IsFullTime's getter.
  * Removed Student.Email's setter, as the email is generated as a function of student's first/last/id.
  *   Because Student.Email is now data-driven, Student's second constructor now accepts 4 parameters vs the specified 5.
  * Initialized the IDCount value to 1000, as the 4 digits most closely matched the scheme.

* I implemented the list of students that the form iterates through as a static member of the Student class.
