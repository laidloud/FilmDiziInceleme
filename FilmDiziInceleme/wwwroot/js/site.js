document.querySelector('form').addEventListener('submit',
    function (e) {
        const name = document.getElementById('Name').value;
        if (name.trim() === "") {
            alert("Ürün adı boş bırakılamaz.");
            e.preventDefault();
        }
    });