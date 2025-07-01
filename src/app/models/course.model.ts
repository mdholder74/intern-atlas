export interface Course {
    id: number;
    title: string;
    description: string;
    duration: string; // in hours
    difficulty: string; // e.g., "beginner", "intermediate", "advanced"
    personalNotesUrl?: string; // URL to personal notes
    officialDocsUrl?: string; // URL to official documentation
    linkedInVideoUrl?: string; // URL to LinkedIn Learning video
    review?: string; // personal review of the course
    tags?: string[]; // array of tags for categorization
    codeSnippets?: string[]; // array of code snippets related to the course
    img?: string;// URL to the course image
}
