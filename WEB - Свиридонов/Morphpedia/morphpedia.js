//ЗАПУСТИ LIVE SERVER 

let morphData = {}; 

async function loadMorphData() 
{
    try
    {
        let response = await fetch('./morphData/MorphData.json');  
        morphData = await response.json();
        console.log(morphData)
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
            let li = document.createElement("li");
            li.textContent = morph;
            li.onclick = () => showMorphInfo(animal, morph); //лямбда функциия для обработчика OnClick HTML.

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
//loadMorphData();


