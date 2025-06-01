<template>
    <header class="site-header">
  <div class="container">
    <h1 class="logo">Morphpedia</h1>
  </div>
  </header>

  <div id="app">
    <router-view />
  </div>
</template>

<script>
export default {
  name: 'App'
}
</script>

<style>
.site-header {
  background: linear-gradient(90deg, #42b983, #368f6e);
  color: white;
  padding: 1rem 0;
  box-shadow: 0 3px 8px rgba(0, 0, 0, 0.15);
  position: sticky;
  top: 0;
  z-index: 1000;
  font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
  margin-bottom: 20px;
}

.container {
  max-width: 1100px;
  margin: 0 auto;
  padding: 0 1rem;
  display: flex;
  align-items: center;
  justify-content: space-between;
}

.logo {
  font-weight: 700;
  font-size: 1.8rem;
  letter-spacing: 2px;
  user-select: none;
  cursor: default;
  text-shadow: 1px 1px 3px rgba(0,0,0,0.2);
}

body{
  margin: 0;
}
</style>
