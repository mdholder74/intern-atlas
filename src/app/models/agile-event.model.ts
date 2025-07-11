export interface AgileEvent {
    id: number;
    type: string; // e.g., "sprint", "release", "planning", "review"
    items: string[]; // List of items related to the event
}
