if (document.querySelector('.accordion-container')) {
    new Accordion('.accordion-container');
  }

  document.addEventListener('DOMContentLoaded', () => {
    const swiper = new Swiper('.swiper-review', {
      slidesPerView: 'auto',
      spaceBetween: 19,
      navigation: {
        nextEl: '.swiper-button-next',
        prevEl: '.swiper-button-prev',
      },
    });

  });

  const asideDownHeader = document.querySelector('.aside__content-down-header');
  const asideDownBody = document.querySelector('.aside__content-down-body');

  if (asideDownHeader) {
    asideDownHeader.addEventListener('click', () => {
      asideDownBody.classList.toggle('active');
      asideUpBody.classList.remove('active');
    });
  }
  const asideUpHeader = document.querySelector('.aside__content-up-header');
  const asideUpBody = document.querySelector('.aside__content-up-body');

  if (asideUpHeader) {
    asideUpHeader.addEventListener('click', () => {
      asideUpBody.classList.toggle('active');
      asideDownBody.classList.remove('active');
    });
  }




  
  
  document.addEventListener('DOMContentLoaded', () => {
    const langSwitcher = document.querySelector('.header__lang-switcher');
    const selectedLanguage = document.querySelector('.header__selected-language');
    const languageOptions = document.querySelector('.header__language-options');
  

    selectedLanguage.addEventListener('click', () => {
      languageOptions.classList.toggle('hidden');
      langSwitcher.classList.toggle('active');
    });
  

    languageOptions.addEventListener('click', (event) => {
      const selectedOption = event.target.closest('.header__language-option');
  
      if (selectedOption) {
        const langNameElement = selectedOption.querySelector('.header__language-name');
        const flagElement = selectedOption.querySelector('img');
  

        if (langNameElement && flagElement) {
          const newLangCode = langNameElement.textContent;
          const newFlagSrc = flagElement.src;
  

          const selectedLangName = document.querySelector('.header__selected-language .header__language-name');
          const selectedFlag = document.querySelector('.header__selected-language img');
          
          if (selectedLangName && selectedFlag) {
            selectedLangName.textContent = newLangCode;
            selectedFlag.src = newFlagSrc;
          }
  

          languageOptions.classList.add('hidden');
          langSwitcher.classList.remove('active');
        }
      }
    });
  

    document.addEventListener('click', (event) => {
      if (!langSwitcher.contains(event.target)) {
        languageOptions.classList.add('hidden');
        langSwitcher.classList.remove('active');
      }
    });
  });
  

  const burgerButton = document.querySelector('.header__burger');
const menu = document.querySelector('.burger');


if (burgerButton) {
  burgerButton.addEventListener('click', () => {
    burgerButton.classList.toggle('active');
    menu.classList.toggle('open');
  });
}
  const modal1Button = document.querySelector('.modal1__button');
const modal1 = document.querySelector('.modal1');
const modal1Close = document.querySelector('.modal1__close');


if (modal1Button) {
  modal1Button.addEventListener('click', () => {
    modal1.classList.toggle('open');
  });

}

if (modal1Close) {
  modal1Close.addEventListener('click', () => {
    modal1.classList.remove('open');
  });
}

  const modal2Button = document.querySelector('.modal2__button');
const modal2 = document.querySelector('.modal2');
const modal2Close = document.querySelector('.modal2__close');


if (modal2Button) {
  modal2Button.addEventListener('click', () => {
    modal2.classList.toggle('open');
  });
}

if (modal2Close) {
  modal2Close.addEventListener('click', () => {
    modal2.classList.remove('open');
  });
}
