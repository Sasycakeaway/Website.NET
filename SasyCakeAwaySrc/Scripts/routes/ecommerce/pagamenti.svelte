<script>
  import { dialogs } from "svelte-dialogs";
  import md5 from "md5";
  import { init, getorder, getvariable } from "../../lib/js/paypal";
  import { onMount } from "svelte";
  import { GooglePlacesAutocomplete } from "@beyonk/svelte-googlemaps";
  //import google from 'https://maps.googleapis.com/maps/api/js?key=AIzaSyBomQdV10KKTb45y-uIXWl-ZlFgyEOxcsc&libraries=places&callback=initMap'
  let nome,
    cognome,
    indirizzo,
    cap,
    domicilio = false,
    totale,
    user,
    pass,
    cart,
    cittavar;
  onMount(async () => {
    user = sessionStorage.getItem("email");
    totale = localStorage.getItem("totale");
    pass = sessionStorage.getItem("password");
    cart = localStorage.getItem("cart");
    if (user == null || pass == null) {
      dialogs
        .alert("Per completare il pagamento devi accedere al sito")
        .then(() => {
          location.href = "/ecommerce/login";
        });
    }
  });
  function pagamento() {
    if (nome != null && cognome != null && indirizzo != null && cap != null) {
      indirizzo = cittavar + "," + indirizzo;
      console.log(domicilio.toString());
      init(
        totale,
        nome,
        cognome,
        indirizzo,
        cap,
        domicilio.toString(),
        user,
        pass,
        cart
      );
      document.getElementById("conf").style.visibility = "hidden";
    } else alert("Compila tutti i campi richiesti");
  }

  function citta(e) {
    cittavar = e.detail.place.formatted_address;
  }
</script>

<svelte:head>
  <!-- <script src="https://staging.online.satispay.com/web-button.js"></script> -->
  <script
    src="https://www.paypal.com/sdk/js?client-id=AXG9tYzRz10-7z2Hhro6tScAENTIHDtqWdFL9gqCx2hcH8-VqKG6gs1n3yMZzge6UvLVECsfdtezoLTk&currency=EUR"
    data-namespace="paypal_sdk"></script>
  <link rel="stylesheet" href="/css/pagamenti.css" />
</svelte:head>
<br />
<br />
<div align="center" class="form">
  <fieldset class="uk-fieldset">
    <legend class="uk-legend">Modulo di pagamento</legend>

    <div class="uk-margin">
      <input
        class="uk-input"
        type="text"
        placeholder="Nome"
        bind:value={nome}
      />
      <br />
      <br />

      <input
        class="uk-input"
        type="text"
        placeholder="Cognome"
        bind:value={cognome}
      />
      <br />
      <br />
      <GooglePlacesAutocomplete
        apiKey="AIzaSyCcnkrkY74xBbIDf4UZdYH4bZwXaSvh1nM"
        styleClass="uk-input"
        on:placeChanged={citta}
        placeholder="Città"
      />
      <br />
      <br />
      <input
        class="uk-input"
        type="input"
        placeholder="Indirizzo di consegna"
        bind:value={indirizzo}
        id="map"
      />
      <br />
      <br />
      <input class="uk-input" type="text" placeholder="CAP" bind:value={cap} />
      <br />
      <br />
      <input
        type="checkbox"
        id="domicilio"
        name="domicilio"
        bind:checked={domicilio}
      />
      <label for="domicilio"
        >Consegna a domicilio o spedizione se l'indirizzo di consegna è fuori
        dal Piemonte</label
      >

      <br />
      <br />
    </div>
    <div align="center" />
  </fieldset>
</div>
<div align="center" id="conf">
  <button class="uk-button uk-button-primary" on:click={pagamento}
    >Procedi al pagamento</button
  >
</div>

<div id="paypal" align="center" />
<br />
