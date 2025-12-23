namespace TaskFlow.Domain.Enums
{
    public enum PriorityLevel
    { 
        Low = 0,
        Medium = 1,
        High = 2,
        Critical = 3
    }

    public enum TicketStatus
    { 
        Todo = 0,
        InProgress = 1,
        InReview = 2,
        Done = 3,
    }
}
