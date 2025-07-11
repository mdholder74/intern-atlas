export interface User {
  id: number;
  name: string;
  email?: string;
  committedCourseIds?: number[];
}
