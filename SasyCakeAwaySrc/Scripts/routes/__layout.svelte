<script>
  import 'uikit/dist/css/uikit.css';
  import 'uikit/dist/js/uikit.js';
  import 'uikit/dist/js/uikit-icons.js';
  import Header from "$lib/header/Header.svelte";
  import "./app.css";
  import { onMount } from "svelte";
  import { dialogs } from "svelte-dialogs";
  onMount(() => {
    dialogs.config({
      global: {
        closeButtonText: "close me",
        resetButton: false,
        cancelButtonText: "Annulla",
        submitButtonText: "Aggiungi al carrello",
      },
    });
  });
  function facebook(){
    window.open("https://www.facebook.com/sasy.cakeaway");
  }
  function instagram(){
    window.open("https://www.instagram.com/sasy_cakeaway/");
  }
  function github(){
    window.open("https://github.com/Sasycakeaway/Website");
  }
</script>

<svelte:head>
  <link rel="stylesheet" href="/css/footer.css" />
    <!-- Google Tag Manager -->
  <script>(function(w,d,s,l,i){w[l]=w[l]||[];w[l].push({'gtm.start':
    new Date().getTime(),event:'gtm.js'});var f=d.getElementsByTagName(s)[0],
    j=d.createElement(s),dl=l!='dataLayer'?'&l='+l:'';j.async=true;j.src=
    'https://www.googletagmanager.com/gtm.js?id='+i+dl;f.parentNode.insertBefore(j,f);
    })(window,document,'script','dataLayer','GTM-PRD2VH2');</script>
  <!-- End Google Tag Manager -->
  <script src="https://www.googleoptimize.com/optimize.js?id=GTM-KMRMVZC"></script>
</svelte:head>

<Header />

<body>
  <main>
    <slot />
  </main>
</body>
<!-- Google Tag Manager (noscript) -->
<noscript><iframe src="https://www.googletagmanager.com/ns.html?id=GTM-PRD2VH2"
  height="0" width="0" style="display:none;visibility:hidden"></iframe></noscript>
  <!-- End Google Tag Manager (noscript) -->
<footer>
  <p class="titindirizzo">Mi trovi in Viale falchera 69</p>
  <p style="color: white;">Seguici su Instagram e Facebook</p>
  <div uk-grid>
    <div>
      <a href="#0" on:click={instagram}
        ><img alt="instagram"
          src="https://img.icons8.com/material-outlined/48/000000/instagram-new--v1.png"
        /></a
      >
    </div>
    <div>
      <a href="#0" on:click={facebook} alt="facebook"
        ><img src="https://img.icons8.com/ios/48/000000/facebook--v1.png" /></a
      >
    </div>
  </div>
  <p class="social" style="margin-bottom:40px">&copy; Sasy's Cake Away</p>
  <p class="src" style="margin-top:150px">
    Codice sorgente del sito su <a
      href="#0" on:click={github}>Github</a
    >
  </p>
</footer>

<style>
  
  footer {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    padding: 40px;
    background-color: #ffffff;
  }

  footer a {
    font-weight: bold;
  }
  .uk-position-relative{
    color: black;
  }
</style>
