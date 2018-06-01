

function myFunction(Ref) {
    var x = document.getElementById(Ref);
    if (x.style.display === 'none') {
        x.style.display = 'block';
    } else {
        x.style.display = 'none';
    }
}

function VanillaRequests(method, adress, arguments, parameters) {
    var xhr = new XMLHttpRequest();
    if (method === 'GET') {
        Object.keys(arguments).forEach((key, index) => {
            if (index !== (arguments.length - 1)) {
            adress = adress + '?' + key + '=' + arguments(key) + '&';
        } else {
            adress = adress + '?' + key + '=' + arguments(key);
        }
    });
        xhr.open(method, adress);
        xhr.send();
    } else if (method === POST) {
        xhr.open(method, adress);
        xhr.send(parameters);
    }
    xhr.onreadystatechange = function() { //Call a function when the state changes.
        if (xhr.readyState === 4 && xhr.status === 200) {
            alert(xhr.responseText);
        }
    }
}


var modal = document.getElementById('myModal');
// Get the button that opens the modal
var btn = document.getElementById("trajetBtn");
// Get the <span> element that closes the modal
var span = document.getElementsByClassName("close")[0];
// When the user clicks on the button, open the modal 
/*btn.onclick = function() {
    modal.style.display = "block";
}*/
// When the user clicks on <span> (x), close the modal
span.onclick = function() {
    modal.style.display = "none";
}
// When the user clicks anywhere outside of the modal, close it
window.onclick = function(event) {
    if (event.target === modal) {
        modal.style.display = "none";
    }
}

function setLieu(lieu) {
//            lieuEvenement = lieu;
    console.log('lieu', lieu)
    document.getElementById('lieu').value = lieu;
    modal.style.display = "block";
}