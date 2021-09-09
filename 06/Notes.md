## Validations in Asp.Net
- Validation a way to check user's input if its valid. By this way we prevent errorneous round trip to the backend.
- Client side validation
  - validate data at client side, using html attributes like required, minlength, maxlength, min, max, pattern
  - JavaScript or jquery can also be used to do advanced validations.
- Server side Validation
  - validating user's input from the server-side code.
  - Ex: User's Login, checkin username availibility 
- validation in Asp.Net forms include the controls:
  - RequiredFieldValidator
  - RangeValidator
  - CompareValidator
  - RegularExpressionValidator
  - ValidationSummary 
  - CustomValidator
    - Use BaseValidator class to implement custom validator

## Ajax
- Asynchronous JavaScript and XML
- in JS XMLHttpRequest object was used to make server side calls.