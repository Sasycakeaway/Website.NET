import { onMount } from "svelte";
import { pusha, initcart } from "./cart";
import { dialogs } from "svelte-dialogs";
export function initpage() {
  onMount(() => {
    initcart();
    if (
      /Android|webOS|iPhone|iPad|iPod|Opera Mini/i.test(navigator.userAgent)
    ) {
    } else {
      document.getElementById("card").style.width = "60%";
    }
  });
}

export function biscotti(e) {
  console.log(e);
  dialogs.prompt("Quanti sacchetti da 250G vuoi ordinare?").then((output) => {
    try {
      pusha(e, output[0], 5);
    } catch (error) {
      console.log(error);
    }
  });
}

export function pezzi(e) {
  dialogs.prompt("Quanti " + e + " vuoi ordinare?").then((output) => {
    try {
      pusha(e, output[0], 5);
    } catch (error) {}
  });
}

export function apebox(e) {
  dialogs.prompt("Quanti box vuoi ordinare?").then((output) => {
    try {
      switch (e) {
        case "Benvenuti al nord":
          pusha(e, output[0], 12);
          break;
        case "Il vegetariano":
          pusha(e, output[0], 12);
          break;
        case "Il trasformista":
          pusha(e, output[0], 18);
          break;
        default:
          pusha(e, output[0], 15);
          break;
      }
    } catch (error) {
      console.log(error);
    }
  });
}
