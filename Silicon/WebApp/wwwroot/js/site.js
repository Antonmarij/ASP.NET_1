document.addEventListener("DOMContentLoaded", () => {
    let btnMenu = document.querySelector('.btn-menu')
    let nav = document.querySelector('nav')

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


//function initMap() {
//    const options = {
//        center: { lat: 37.73418426513672, lng: -122.4065170288086 },
//        zoom: 8
//    };

//    map = new google.maps.Map(document.getElementById("map"), options);
//}

//initMap();


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

if (window.matchMedia('(prefers-color-scheme: dark)').matches) {
    document.documentElement.setAttribute('data-theme', 'dark');
    checkbox.checked = true;
} else {
    document.documentElement.setAttribute('data-theme', 'light');
    checkbox.checked = false;
}


checkbox.addEventListener('change', (cb) => {
    document.documentElement.setAttribute(
        'data-theme',
        cb.target.checked ? 'dark' : 'light'
    );
});