export interface Course {
    id: number;
    title: string;
    description: string;
    duration: number; // in hours
    level: string; // e.g., "beginner", "intermediate", "advanced"
    link?: string;// URL to the course page
    img?: string;// URL to the course image
}
