/* ==========================================================================
   LRMS — LABOUR ROOM MANAGEMENT SYSTEM
   Login Screen Behaviour
   ========================================================================== */

(function () {
    "use strict";

    document.addEventListener("DOMContentLoaded", init);

    function init() {
        initPasswordToggle();
        initInputFocusStates();
        initSignInSubmit();
        initFooterDateTime();
    }

    /* ----------------------------------------------------------------------
       Password visibility toggle
       ---------------------------------------------------------------------- */
    function initPasswordToggle() {
        var toggleBtn = document.getElementById("togglePassword");
        var toggleIcon = document.getElementById("togglePasswordIcon");
        var passwordInput = document.getElementById("password");

        if (!toggleBtn || !toggleIcon || !passwordInput) {
            return;
        }

        toggleBtn.addEventListener("click", function () {
            var isHidden = passwordInput.getAttribute("type") === "password";

            passwordInput.setAttribute("type", isHidden ? "text" : "password");
            toggleBtn.setAttribute("aria-pressed", isHidden ? "true" : "false");
            toggleBtn.setAttribute("aria-label", isHidden ? "Hide password" : "Show password");

            toggleIcon.classList.toggle("fa-eye", !isHidden);
            toggleIcon.classList.toggle("fa-eye-slash", isHidden);

            // Keep focus on the field after toggling for smooth keyboard UX
            passwordInput.focus({ preventScroll: true });
        });
    }

    /* ----------------------------------------------------------------------
       Input focus / interaction enhancements
       ---------------------------------------------------------------------- */
    function initInputFocusStates() {
        var fields = document.querySelectorAll(".form-field");

        fields.forEach(function (field) {
            var input = field.querySelector(".field-input");
            if (!input) {
                return;
            }

            input.addEventListener("focus", function () {
                field.classList.add("is-focused");
            });

            input.addEventListener("blur", function () {
                field.classList.remove("is-focused");
                field.classList.toggle("is-filled", input.value.trim().length > 0);
            });
        });
    }

    /* ----------------------------------------------------------------------
       Sign In button loading state (placeholder for real auth call)
       ---------------------------------------------------------------------- */
    function initSignInSubmit() {
        var form = document.querySelector(".login-form");
        var signInBtn = document.getElementById("signInBtn");

        if (!form || !signInBtn) {
            return;
        }

        form.addEventListener("submit", function () {
            if (signInBtn.classList.contains("is-loading")) {
                return;
            }

            signInBtn.classList.add("is-loading");
            signInBtn.disabled = true;
        });
    }

    /* ----------------------------------------------------------------------
       Footer live date / time
       ---------------------------------------------------------------------- */
    function initFooterDateTime() {
        var dateEl = document.getElementById("footerDate");
        var timeEl = document.getElementById("footerTime");

        if (!dateEl || !timeEl) {
            return;
        }

        updateDateTime();
        setInterval(updateDateTime, 60 * 1000);

        function updateDateTime() {
            var now = new Date();

            dateEl.textContent = formatDate(now);
            timeEl.textContent = formatTime(now);
        }

        function formatDate(date) {
            var months = [
                "Jan", "Feb", "Mar", "Apr", "May", "Jun",
                "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
            ];
            var day = String(date.getDate()).padStart(2, "0");
            return day + " " + months[date.getMonth()] + " " + date.getFullYear();
        }

        function formatTime(date) {
            var hours = date.getHours();
            var minutes = String(date.getMinutes()).padStart(2, "0");
            var period = hours >= 12 ? "PM" : "AM";

            hours = hours % 12;
            hours = hours === 0 ? 12 : hours;

            return hours + ":" + minutes + " " + period;
        }
    }

})();
