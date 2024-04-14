document.addEventListener("DOMContentLoaded", () => {
    let btnMenu = document.querySelector('.btn-menu')
    let nav = document.querySelector('nav')
    handleProfileImageUpload()

    btnMenu.addEventListener('click', () => {
        btnMenu.classList.toggle('active')
        btnMenu.classList.toggle('fixed')

        nav.classList.toggle('active')
    })

    window.addEventListener('resize', () => {
        btnMenu.classList.remove('active')
        btnMenu.classList.remove('fixed')

        nav.classList.remove('active')
    }) 
})


function handleProfileImageUpload() {
    try {

        let fileUploader = document.querySelector('#fileUploader')
        if (fileUploader != undefined) {
            fileUploader.addEventListener('change', function () {
                if (this.files.length > 0) {
                    this.form.submit()
                }
            })
        }

    }
    catch { }
}



let map;

async function initMap() {
    const { Map } = await google.maps.importLibrary("maps");

    map = new Map(document.getElementById("map"), {
        center: { lat: 59.34538650512695, lng: 18.02353286743164 },
        zoom: 8,
    });
}

initMap();


let checkbox = document.querySelector('input[id=theme-switch-mode]');

//funkade inte ordentligt, mindes inte mellan sidor vilken mode som var vald senast
//if (window.matchMedia('(prefers-color-scheme: dark)').matches) {
//    document.documentElement.setAttribute('data-theme', 'dark');
//    checkbox.checked = true;
//} else {
//    document.documentElement.setAttribute('data-theme', 'light');
//    checkbox.checked = false;
//}


checkbox.addEventListener('change', (cb) => {
    document.documentElement.setAttribute(
        'data-theme',
        cb.target.checked ? 'dark' : 'light'
    );
});

//validering

let forms = document.querySelectorAll('form')


forms.forEach(form => {

    let inputs = form.querySelectorAll('input');

    inputs.forEach(input => {
        if (input.dataset.val === 'true') {
            input.addEventListener('keyup', (e) => {
                switch (e.target.type) {
                    case 'text':
                        textValidation(e, e.target.dataset.valMinlengthMin)
                        break

                    case 'email':
                        emailValidation(e)
                        break

                    case 'password':
                        passwordValidation(e)
                        break

                    case 'tel':
                        phoneValidation(e)
                        break
                }
            })
        }
    })
});

const handleValidationOutput = (isValid, e, text = "") => {
    let span = document.querySelector(`[data-valmsg-for="${e.target.name}"]`)

    if (isValid) {
        e.target.classList.remove('input-validation-error')
        span.classList.remove('field-validation-error')
        span.classList.add('field-validation-valid')
        span.innerHTML = ""

    } else {
        e.target.classList.add('input-validation-error')
        span.classList.add('field-validation-error')
        span.classList.remove('field-validation-valid')
        span.innerHTML = text
    }
}



const textValidation = (e, minLength = 1) => {
    if (e.target.value.length > 0)
        handleValidationOutput(e.target.value.length >= minLength, e, e.target.dataset.valMinlength)
    else
        handleValidationOutput(false, e, e.target.dataset.valRequired)
}




const emailValidation = (e) => {
    const regEx = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*\.[a-zA-Z]{2,}$/

    if (e.target.value.length > 0)
        handleValidationOutput(regEx.test(e.target.value), e, e.target.dataset.valRegex)
    else
        handleValidationOutput(false, e, e.target.dataset.valRequired)
}




const passwordValidation = (e) => {
    const regEx = /^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[\W_])(?!.*\s).{8,}$/


    let compareTo = document.querySelector(e.target.dataset.valEqualtoOther)

    if (e.target.value.length > 0)
        handleValidationOutput(regEx.test(e.target.value), e, e.target.dataset.valRegex)
    else
        handleValidationOutput(false, e, e.target.dataset.valRequired)
}

const phoneValidation = (e) => {

    const regEx = /^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$/

    if (e.target.value.length > 0)
        handleValidOutput(regEx.test(e.target.value), e, e.target.dataset.valRegex)
    else
        handleValidOutput(false, e, e.target.dataset.valRequired)

}