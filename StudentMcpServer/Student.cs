using System;
using System.Collections.Generic;
using System.Text;

namespace StudentMcpServer
{
    /// <summary>
    /// Represents a student entity with basic identification details.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Gets or sets the unique identifier for the student.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the full name of the student.
        /// </summary>
        public string Name { get; set; } = string.Empty;
    }
}
