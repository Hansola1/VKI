<template>
  <head>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css">
  </head>

  <header class="site-header">
    <h1 class="logo">Morphpedia</h1>
    <div class="auth-buttons">
      <button class="login-btn">Войти</button>
      <button class="registration-btn">Регистрация</button>
    </div>
  </header>

  <div id="app">
    <router-view />
  </div>

  <footer class="site-footer">
    <div class="footer-content">
      <p class="footer-logo">Morphpedia</p>
        <div class="social-links">
          <a href="https://vk.com/hansogeckon" title="Наш питомник" target="_blank">
                <i class="fab fa-vk"></i> 
                <label>Питомник</label>
            </a>
          <a href="https://t.me/hansogeckon" title="Новости" target="_blank">
              <i class="fab fa-telegram"></i>
              <label>Новости</label> 
          </a>
        </div>
    </div>
  </footer>
</template>

<script>
export default {
  name: 'App'
}
</script>

<style>
@font-face {
  font-family: 'Codenext';
  src: url('./assets/fonts/CodeNext-Trial-ExtraBold.ttf') format('truetype');
  font-weight: 800;
  font-style: normal;
}

.site-header {
  background: linear-gradient(90deg, #FFFFFF, #FFFFFF);
  color: rgb(0, 0, 0);
  padding: 1.4rem;
  box-shadow: 0 3px 15px rgba(0, 0, 0, 0.034);
  justify-content: space-between;
  position: fixed;
  display: flex;
  top: 0;
  left: 0;
  width: 100%;
  z-index: 1000;
}

.logo {
  font-family: 'Codenext', sans-serif; 
  letter-spacing: 5px;
  font-weight: 800; 
  font-size: 1.5rem;
  margin-top: 0px;
  margin-bottom: 0px;
  margin-right: 4px;
  user-select: none;
  cursor: default;
}

body {
  margin: 0;
  padding-top: 60px; 
  background-color: #fefefe;
  min-height: 100vh;
  position: relative;
  padding-bottom: 60px; 
}

.site-footer {
  background-color: #252525;
  color: white;
  padding: 1.5rem 0;
  text-align: center;
  position: absolute;
  bottom: 0;
  width: 100%;
}

.footer-content {
  max-width: 1200px;
  margin: 0 auto;
  padding: 0 1rem;
}

.footer-logo {
  font-family: 'Codenext', sans-serif;
  font-size: 1.2rem;
  letter-spacing: 2px;
  margin-bottom: 0.5rem;
  color: #ffffff;
}

.copyright {
  font-size: 0.9rem;
  color: #aaaaaa;
  margin-top: 0;
}

.social-links {
  font-family: 'Codenext', sans-serif; 
  letter-spacing: 1px;
  display: flex;
  justify-content: center;
  gap: 1.5rem;
  margin: 1rem 0;
}

.social-links a {
  color: white;
  text-decoration: none;
  display: flex;
  align-items: center;
  gap: 0.5rem;
  transition: color 0.2s;
}

.social-links a:hover {
  filter: drop-shadow(0 0 15px rgba(255, 255, 255, 0.8));
}

.social-links label {
  font-size: 0.9rem;
}

.auth-buttons {
  display: flex;
  gap: 1rem;
  padding-right: 2rem;
}

.login-btn{
  background-color: #000;
  color: white;
  border: none;
}
.registration-btn{
  background-color: white;
  border: 2px solid black;
  color: black;
}

.login-btn,
.registration-btn {
  border-radius: 20px; 
  padding: 0.6rem 1.5rem;
  font-size: 0.9rem;
  font-weight: 600;
  cursor: pointer;
  transition: all 0.3s ease;
  min-width: 80px; 
  text-align: center;
}

.login-btn:hover,
.registration-btn:hover {
  border-radius: 10px; 
}
</style>