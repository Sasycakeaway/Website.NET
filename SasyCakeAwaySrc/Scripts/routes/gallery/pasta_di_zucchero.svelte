<script>
  import item from "$lib/images/slide/Pasta di zucchero/list.json";
  import Gallery from "$lib/components/gallery.svelte";
  import { dialogs } from "svelte-dialogs";
</script>

<br />
<div class="gallo">
  <Gallery
    on:click={(event) =>
      dialogs.alert(
        "<img src=" +
          event.detail.src +
          ' alt="Placeholder Image" width="512px"/>'
      )}
  >
    {#each item as prod}
      {#if prod != "list.json"}
        <img src={"/images/slide/Pasta di zucchero/" + prod} alt="prod" />
      {/if}
    {/each}
  </Gallery>
</div>
<br />

<style>
  .gallo {
    margin-left: 50px;
    margin-right: 50px;
  }
</style>
