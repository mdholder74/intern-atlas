# Changelog

All notable changes to the Intern Atlas Components Library will be documented in this file.

## [1.0.0] - 2025-01-19

### Added
- Initial library extraction from intern-atlas project
- **Models**: Course, User, AgileEvent, AzureStage interfaces
- **Services**: CourseService, AgileEventService, AzureStageService 
- **Components**: 
  - SiteNavHeader - Navigation header component
  - CodeSnippet - Code display component with copy functionality
  - CommitmentForm - Course commitment form component
  - CouresList - Course listing component  
  - CourseCard - Individual course card component
  - CourseDetail - Detailed course view component
- Complete Angular library workspace with build configuration
- Comprehensive README with usage instructions
- TypeScript definitions and public API exports

### Technical Details
- Extracted from commit: refactor: update resource links in course detail and improve swagger URL handling
- Preserved original component structure and functionality
- Angular 20.x compatible
- Includes CSS styling for all components
- Full test file structure maintained

### Dependencies
- Angular 20.1.0+
- RxJS ~7.8.0
- Requires Angular Router and Forms modules

### Build & Publishing
- Buildable with `npm run build`
- Publishable with `npm run pack:lib`
- Includes proper TypeScript definitions
- Ready for npm registry publishing