window.startAnimation = function (instance) {
    var player = document.querySelector('lottie-player');
    var animation = document.querySelector('.animation');
    player.addEventListener('complete', function () {
        animation.classList.add('fade-out');
        setTimeout(function () {
            animation.classList.remove('fade-out');
            instance.invokeMethodAsync('OnAnimationComplete');
        }, 1000);
    });
    player.play();
};