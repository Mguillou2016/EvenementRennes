

function myFunction(Ref) {
    var x = document.getElementById(Ref);
    if (x.style.display === 'none') {
        x.style.display = 'block';
    } else {
        x.style.display = 'none';
    }
}

function VanillaRequests(method, adress, arguments, parameters, csv) {
    return new Promise((resolve, reject) => {
        var xhr = new XMLHttpRequest();
        if (method === 'GET' && arguments !== {}) {
            Object.keys(arguments).forEach((key, index) => {
                if (index !== (arguments.length - 1)) {
                    adress = adress + '?' + key + '=' + arguments(key) + '&';
                } else {
                    adress = adress + '?' + key + '=' + arguments(key);
                }
            });
            xhr.open(method, adress);
            xhr.send();
        } else if (method === 'POST' && parameters !== {}) {
            xhr.open(method, adress);
            xhr.send(parameters);
        } else {
            if (csv === true) {
                xhr.overrideMimeType('text/csv');
            }
            xhr.open(method, adress);
            xhr.send();
        }
        xhr.onreadystatechange = function() {
            if (xhr.readyState === 4 && xhr.status === 200) {
                resolve(xhr.responseText);
            }
        }
    })
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