function validate() {
  var requiredInputs = document.getElementsByClassName("required");
  //console.log(requiredInputs);
  let isValid = true;

  for (let index = 0; index < requiredInputs.length; index++) {
    const element = requiredInputs[index];
    isValid = isRequired(element) && isValid;
  }
  return isValid;
}

function isRequired(element) {
  let isAvailable = true;
  let value = element.value;
  if (value === "") {
    let span = element.getAttribute("data-target");
    let message = element.getAttribute("data-message");

    element.addEventListener("change", function () {
      document.getElementById(span).innerText = "";
    });

    document.getElementById(span).innerText = message;
    isAvailable = false;
  }

  return isAvailable;
}
