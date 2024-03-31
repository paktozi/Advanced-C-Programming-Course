function lockedProfile() {

    const profileElements = document.querySelectorAll('.profile');
    for (let profileElement of profileElements) {

        const showButtonElement = profileElement.querySelector('button');
        const lockRadioElement = profileElement.querySelector('input[type=radio][value=lock]');

        showButtonElement.addEventListener('click', (e) => {

            if (lockRadioElement.checked) {
                return;
            }
            const additionalInfoElement = showButtonElement.previousElementSibling;

            if (showButtonElement.textContent === 'Show more') {
                additionalInfoElement.style.display = 'block';
                showButtonElement.textContent = 'Hide it';
            }
            else {
                additionalInfoElement.style.display = 'none';
                showButtonElement.textContent = 'Show more';
            }
        });
    }
}