let morphData = {}; 
let URL_json = "../morphData/MorphData.json";

async function loadMorphData() 
{
    try
    {
        const response = require('./morphData/MorphData.json')
        console.log(response); 
        morphData = await response.json();
    }
    catch (error) 
    {
        console.log('Ошибка загрузки данных:', error);
    }
}

async function showMorphs(animal) 
{
    await loadMorphData(); 
    
    let morphList = document.getElementById("morphList");
    let error = document.getElementById("errorMessage");
    let morphInfo = document.getElementById("morphInfo");

    morphList.innerHTML = ""; 
    morphInfo.innerHTML = ""; 
    error.innerHTML = "";

    if (morphData[animal]) 
    {
        Object.keys(morphData[animal]).forEach((morph) => 
        {
            const li = document.createElement("li");
            li.textContent = morph;
            li.onclick = () => showMorphInfo(animal, morph); 
            morphList.appendChild(li);
        });
    } 
    else 
    {
        error.innerHTML = "<li>Статьи в процессе создания :)</li>";
    }
}

async function showMorphInfo(animal, morph) 
{
    let morphInfo = document.getElementById("morphInfo");
    let data = morphData[animal][morph];

    morphInfo.innerHTML = `
    <h3>${morph}</h3>
    <img src="${data.image}" alt="${morph}" class="morph-image">
    <p>${data.description}</p>
    `;
}

loadMorphData();
//window.onload = () => { loadMorphData(); };
