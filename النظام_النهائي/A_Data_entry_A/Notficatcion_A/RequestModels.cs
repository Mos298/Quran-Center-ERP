using System;
using System.Collections.Generic;

namespace النظام_النهائي
{
    // A. Defining the types of requests available in the system
    public enum RequestType
    {
        StudentTransfer,
        DataModification
    }

    // B. Defining the possible statuses for any request
    public enum RequestStatus
    {
        Pending,  // New request, awaiting action
        Approved, // Request has been approved
        Rejected  // Request has been rejected
    }

    // C. The main class that represents a single request/notification
    public class Request
    {
        public int Id { get; set; }
        public RequestType Type { get; set; }
        public RequestStatus Status { get; set; }
        public string SubjectName { get; set; } // e.g., "Student: Ahmed Ali"
        public string InitiatorName { get; set; } // e.g., "Teacher: Khalid Omar"
        public DateTime RequestDate { get; set; }

        // A flexible dictionary to store details specific to the request type
        // For StudentTransfer: "From", "To"
        // For DataModification: "FieldName", "OldValue", "NewValue"
        public Dictionary<string, string> Details { get; set; }

        public Request()
        {
            Details = new Dictionary<string, string>();
        }
    }
}
