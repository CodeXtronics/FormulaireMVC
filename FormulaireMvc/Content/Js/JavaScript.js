function ChangeOnglet_2(active, nombre, tab_prefix, contenu_prefix)
{
    for (var i = 1; i < nombre + 1; i++)
    {
        document.getElementById(contenu_prefix + i).style.display = 'none';
        document.getElementById(tab_prefix + i).className = '';
    }
    document.getElementById(contenu_prefix + active).style.display = 'block';
    document.getElementById(tab_prefix + active).className = 'active';
}

(function ()
{
    var scrollY = function () {
        var supportPageOffset = window.pageXOffset !== undefined;
        var isCSS1Compat = ((document.compatMode || "") === "CSS1Compat");
        var x = supportPageOffset ? window.pageXOffset : isCSS1Compat ? document.documentElement.scrollLeft : document.body.scrollLeft;
        var y = supportPageOffset ? window.pageYOffset : isCSS1Compat ? document.documentElement.scrollTop : document.body.scrollTop;
        return y;
    }
    var element = document.querySelector('#tabs_area')
    var rect = element.getBoundingClientRect()
    var top = rect.top + scrollY()
    var width = rect.width

    var onScroll = function ()
    {
        var hasScrollClass = element.classList.contains('fixed')
        if (scrollY() > top && !hasScrollClass) {
            element.classList.add('fixed')
            //element.style.width = width + "px"
        } else if (scrollY() < top && hasScrollClass) {
            element.classList.remove('fixed')
        }

    }
    var onResize = function ()
    {
        element.style.width = "auto"
        element.classList.remove('fixed')
        rect = element.getBoundingClientRect()
        top = rect.top + scrollY()
        width = rect.width
        onScroll()
    }
    window.addEventListener('scroll', onScroll)
    window.addEventListener('resize',onResize)

})()

