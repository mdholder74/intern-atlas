import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Course } from '../../models/course.model';
import { CourseService } from '../../services/course';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-commitment-form',
  standalone: false,
  templateUrl: './commitment-form.html',
  styleUrl: './commitment-form.css'
})
export class CommitmentForm implements OnInit {
  commitForm!: FormGroup;
  submissionSuccess: boolean = false;
  submissionError: string = '';
  courses: Course[] = [];

  constructor(private formBuilder: FormBuilder, private courseService: CourseService, private route: ActivatedRoute){}

  ngOnInit(): void {
      this.commitForm = this.formBuilder.group({
        name: ['', [Validators.required, Validators.minLength(2), Validators.maxLength(20)]],
        email: ['', [Validators.required, Validators.email]],
        committedCourseIds: [null, Validators.required]
      });

      let preSelectedCourseId: number | null = null;

      this.route.paramMap.subscribe(params => {
        const courseStringId = params.get('id');
        if (courseStringId) {
          preSelectedCourseId = +courseStringId;
        }
      });

      this.courseService.getCourses().subscribe(
        (data: Course[]) => {
          this.courses = data;
          if (preSelectedCourseId) {
            this.commitForm.patchValue({ committedCourseIds: preSelectedCourseId });
          }
        },
        (err: any) => {
          console.error('Error fetching courses:', err);
        }
      );
  }

  get name() {
    return this.commitForm.get('name');
  }

  get email() {
    return this.commitForm.get('email');
  }

  get committedCourseIds() {
    return this.commitForm.get('enrolledCourseId');
  }

  onSubmit(): void {
    if(this.commitForm.invalid) {
      return;
    }

  //   const newUser: User = {
  //     id: 0,
  //     name: this.commitForm.value.name,
  //     email: this.commitForm.value.email,
  //     enrolledCourseIds: [this.commitForm.value.enrolledCourseId]
  //   };

  //   this.courseService.addUser(newUser).subscribe({
  //     next: (user) => {
  //       console.log('Student successfully signed up:', user);
  //       this.submissionSuccess = true;
  //       this.commitForm.reset();
  //     },
  //     error: (err) => {
  //       console.error('Error signing up student:', err);
  //       this.submissionError = 'There was an error submitting your sign-up. Please try again.';
  //     }
  //   })
  }

}
