<template>
    <div class="links">
      <div v-if="!$auth.loading">
        <span v-if="$auth.isAuthenticated" v-on:click='goToHome'>Home</span>
        <span v-if="$auth.isAuthenticated" v-on:click='goToStudents'>Students</span>
        <span v-if="$auth.isAuthenticated" v-on:click='goToInstructors'>Instructors</span>
        <!-- show login when not authenticated -->
        <span v-if="!$auth.isAuthenticated" @click="login">Log in</span>
        <!-- show logout when authenticated -->
        <span v-if="$auth.isAuthenticated" @click="logout">Log out</span>
      </div>
    </div>
</template>

<script>
  export default {
    name: 'NavBar',
    methods: {
      goToHome: function() {
        this.$router.push({ path: 'home' })
      },
      goToStudents: function() {
        this.$router.push({ path: 'students' })
      },
      goToInstructors: function() {
        this.$router.push({ path: 'instructors' })
      },
      login() {
        this.$auth.loginWithRedirect();
      },
      logout() {
        this.$auth.logout({
          returnTo: window.location.origin
        })
      }
    }
  }
</script>

<style scoped>
  span {
      font-family: monospace;
      font-weight: bold;
      font-size: 14pt;
      cursor: pointer;
      padding-right: 20px;
      background-color: white;
      text-align: center;
  }
  .links {
      background-color: lightgray;
      margin-top: 20px;
      padding: 10px;
  }
</style>