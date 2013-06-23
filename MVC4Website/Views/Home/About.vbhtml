@Code
    ViewData("Title") = "About"
End Code

<hgroup class="title">
    <h1>@ViewData("Title").</h1>
    <h2>@ViewData("Message")</h2>
</hgroup>

<article>
    <p>
        <h3>Heres the ML-MC website and official forums:</h3>
        <a href="http://ml-mc.com" title="ML-MC Site">http://ml-mc.com</a>
        <a href="http://ml-mc.com/community" title="ML-MC Forums">http://ml-mc.com/community</a>
    </p>
        
    <p>
        <h4>Heres the game I'm into most at the moment:</h4>
        <a href="http://minecraft.net" title="Minecraft Official Site">http://minecraft.net</a>
    </p>

    <p>
        <h5>Here's my github.com profile:</h5>
        <a href="https://github.com/DeGambler" title="My Github">http://github.com/DeGambler</a>
    </p>
</article>

<aside>
    <h3>Navigation</h3>
    <p>
        Links
    </p>
    <ul>
        <li>@Html.ActionLink("Home", "Index", "Home")</li>
        <li>@Html.ActionLink("About", "About", "Home")</li>
        <li>@Html.ActionLink("Contact", "Contact", "Home")</li>
    </ul>
</aside>