<template>
  <div id="app">
    <NavBar/>
    <router-view/>
  </div>
</template>

<script>
import NavBar from './components/NavBar.vue'

export default {
  name: 'App',
  components: {
    NavBar
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}

 div .table-list {
    color: green;
    font-size: 2em;
}

#homeHeader {
    color: blue;
    font-style: oblique;
}

p  {
    font-family: Georgia;
    color: rgb(85, 102, 102);
}

footer {
    padding: 2em;
    background-color: #f8f9fa;
}

footer div{
    display: flex;
    justify-content: center;
}

.home-wrapper {
    margin-top: 1rem;
    margin-bottom: 1rem;
}
</style>
