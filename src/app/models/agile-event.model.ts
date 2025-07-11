export interface AgileEvent {
    id: number;
    title: string; // e.g., "sprint", "release", "planning", "review"
    items: string[]; // List of items related to the event
}
