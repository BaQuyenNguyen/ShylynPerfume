import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import ValidateForm from 'src/app/helpers/validateForm';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.scss']
})
export class SignupComponent implements OnInit {

  type: string = "password";
  isText: boolean = false;
  eyeIcon: string = "fa-eye-slash";
  signUpForm!: FormGroup;
  constructor(private fb: FormBuilder) { }

  ngOnInit(): void {
    this.createForm();
  }

  hideShowPass(){
    this.isText = !this.isText;
    this.isText ? this.eyeIcon = "fa-eye" : this.eyeIcon = "fa-eye-slash";
    this.isText ? this.type = "text" : this.type = "password";
  }

  createForm(){
    this.signUpForm = this.fb.group({
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      email: ['', Validators.required],
      userName: ['', Validators.required],
      password: ['', Validators.required]
    });
  }

  onSignUp(){
    if(this.signUpForm.valid){

    }else{
      console.log("Form is not valid");

      ValidateForm.validateAllFormFields(this.signUpForm);
      alert("Your form is invalid");
    }
  }
}
