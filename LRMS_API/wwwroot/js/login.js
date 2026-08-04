document.addEventListener("DOMContentLoaded", () => {
    const togglePassword = document.getElementById("togglePassword");
    const passwordInput = document.getElementById("password");

    if (togglePassword && passwordInput) {
        togglePassword.addEventListener("click", () => {
            const isPassword = passwordInput.type === "password";
            passwordInput.type = isPassword ? "text" : "password";
            togglePassword.innerHTML = isPassword
                ? '<i class="fa-regular fa-eye-slash"></i>'
                : '<i class="fa-regular fa-eye"></i>';
        });
    }

    const inputs = document.querySelectorAll(".lrms-input");
    inputs.forEach((input) => {
        input.addEventListener("focus", () => input.parentElement.classList.add("focused"));
        input.addEventListener("blur", () => input.parentElement.classList.remove("focused"));
    });
});