function deleteByEmail() {
    const resultElement = document.getElementById('result');
    const inputMailElement = document.querySelector('input[name=email]');
    const mailListElements = document.querySelectorAll('table#customers tbody tr');
    const searchedElement = Array.from(mailListElements).find(element => element.children[1].textContent.includes(inputMailElement.value));

    if (searchedElement !== undefined) {
        searchedElement.remove();
        resultElement.textContent = 'Deleted.';
    }
    else {
        resultElement.textContent = 'Not found.';
    }
}