export interface Course {
  id: number;
  title: string;
  description: string;
  estimatedEffort: string; // in hours
  difficulty: string; // e.g., "beginner", "intermediate", "advanced"
  personalNotesUrl?: string; // URL to personal notes
  officialDocsUrl?: string; // URL to official documentation
  linkedInVideoUrl?: string; // URL to LinkedIn Learning video
  swaggerUrl?: string; // URL to Swagger documentation
  review?: string; // personal review of the course
  tags?: string[]; // array of tags for categorization
  codeSnippet?: string; // array of code snippets related to the course
  img?: string; // URL to the course image
}
