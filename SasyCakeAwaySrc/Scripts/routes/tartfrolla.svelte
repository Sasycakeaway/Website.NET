<script>
  import { initpage, biscotti } from "../lib/js/pasticceria";
  initpage();
</script>

<svelte:head>
  <title>Home</title>
  <link rel="stylesheet" href="/css/why.css" />
</svelte:head>
<br />
<h1 class="tit">Tartellette di frolla con crema e frutta</h1>
<br />
<div class="" align="center">
  <div class="uk-card uk-card-default" id="card">
    <br />
    <img
      class="imgcenter"
      src="/images/Tartellette di frolla con crema.jpg"
      alt=""
    />
    <div>
      <div class="uk-card-body">
        <p class="det">
          Freschi, gustosi, coloratissimi e di grande effetto scenico, questi
          dolcetti di origine francese si sono imposti anche nella pasticceria
          tradizionale nostrana. Per realizzare questi piccoli bocconcini
          deliziosi serve un cestino di frolla friabile, l’immancabile crema
          pasticcera e tanta creatività, per inventare i migliori accostamenti
          tra la frutta e per curare la presentazione della guarnizione. Un
          tripudio di colori e di sapori che sicuramente vi permetteranno di
          fare un ottima figura con tutti gli ospiti della casa.
        </p>
      </div>
    </div>
  </div>
  <br />
  <button
    class="uk-button uk-button-primary carbut"
    id="Tartellette di frolla con crema"
    on:click={() => biscotti("Tartellette di frolla con crema")}
    >Aggiungi al carrello</button
  >

  <br />
  <div class="testo">
    <p class="citprod" style="color:rgb(195, 0, 255)">
      "E qui si scatena la mia fantasia negli accostamenti tra creme e frutta
      per creare delle piccole opere d'arte"
    </p>
  </div>
</div>

<style>
  .uk-card {
    width: 80%;
  }
  .imgcenter {
    width: 400px;
  }
</style>
