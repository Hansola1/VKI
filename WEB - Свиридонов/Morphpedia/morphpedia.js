let morphData = {}; 

async function loadMorphData() 
{
    try
    {
        const response = await fetch("test.json");
        //console.log(await response.text()); 
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
    
    const morphList = document.getElementById("morphList");
    const error = document.getElementById("errorMessage");
    const morphInfo = document.getElementById("morphInfo");

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

function showMorphInfo(animal, morph) 
{
    const morphInfo = document.getElementById("morphInfo");
    const data = morphData[animal][morph];

    morphInfo.innerHTML = `
    <h3>${morph}</h3>
    <img src="${data.image}" alt="${morph}" class="morph-image">
    <p>${data.description}</p>
    `;
}

//loadMorphData();
window.onload = () => { loadMorphData(); };
