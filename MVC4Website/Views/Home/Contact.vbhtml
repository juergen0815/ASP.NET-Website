@Code
    ViewData("Title") = "Contact"
End Code

<hgroup class="title">
    <h1>@ViewData("Title").</h1>
    <h2>@ViewData("Message")</h2>
</hgroup>

<section class="contact">
    <header>
        <h3>Phone/Skype</h3>
    </header>
    <p>
        <span class="label">Main:</span>
        <span>+4369917276580</span>
    </p>
    <p>
        <span class="label">Skype:</span>
        <span>luke.schober</span>
    </p>
</section>

<section class="contact">
    <header>
        <h3>Email</h3>
    </header>
    <p>
        <span class="label">Support:</span>
        <span><a href="mailto:dev.degambler@gmail.com">Dev.DeGambler@gmail.com</a></span>
    </p>
    
    <p>
        <span class="label">General:</span>
        <span><a href="mailto:lukas.schober@gmail.com">lukas.schober@gmail.com</a></span>
    </p>
</section>

<section class="contact">
    <header>
        <h3>Address</h3>
    </header>
    <p>
        Hans-Resel-Gasse 24<br />
        8020 Graz, Styria
    </p>
</section>