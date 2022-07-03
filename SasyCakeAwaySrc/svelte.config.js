import preprocess from 'svelte-preprocess';
import adapter from 'svelte-adapter-aspcore';

/** @type {import('@sveltejs/kit').Config} */
const config = {
	preprocess: preprocess(),
	kit: {		
    files: {
			assets: 'Assets',
			lib: 'Scripts/lib',
			routes: 'Scripts/routes',
			template: 'Scripts/app.html'
		},
		adapter: adapter({ out : 'build' }),
	}
};

export default config;
