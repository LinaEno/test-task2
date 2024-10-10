html {
  box-sizing: border-box;
  scroll-behavior: smooth;
  overflow-x: hidden;
}

*,
*::before,
*::after {
  padding: 0;
  margin: 0;
  box-sizing: inherit;
}

* {
  scroll-behavior: smooth;
}

body {
  overflow-x: hidden;
  overflow-y: auto;
  background-color: #141E55;
  font-family: "Poppins", sans-serif;
  color: #1b1b1b;
}

body.no-scroll {
  overflow-y: hidden;
}

a {
  text-decoration: none;
  cursor: pointer;
}

button {
  cursor: pointer;
  font-family: inherit;
}

ul, ol {
  padding: 0;
  margin: 0;
  list-style: none;
}

h1,
h2,
h3,
h4,
h5,
h6,
p {
  padding: 0;
  margin: 0;
}

img {
  display: block;
}

.main {
  max-width: 1240px;
  margin: 0 auto;
  display: flex;
  gap: 20px;
  padding-top: 100px;
}

.content {
  width: calc(75% - 10px);
  max-width: 925px;
  display: flex;
  flex-direction: column;
  gap: 20px;
}

.sidebar {
  width: calc(25% - 10px);
  max-width: 295px;
  position: sticky;
  top: 100px;
}

.text {
  font-size: 16px;
  line-height: 24px;
  color: #192A32;
}

.button {
  display: flex;
  align-items: center;
  justify-content: center;
  background-color: #EC622B;
  border-radius: 16px;
  border: 1px solid #FFFFFF;
  outline: none;
  width: 214px;
  height: 48px;
  font-weight: 600;
  font-size: 16px;
  line-height: 20.5px;
  color: #FCFCFC;
  text-transform: uppercase;
  transition: all 0.3s ease;
}
.button:hover {
  background-color: #FFFFFF;
  color: #EC622B;
  border: 1px solid #EC622B;
}

.ac {
  width: 100%;
  margin-top: 0;
  border-radius: 0 0 6px 6px;
}

.ac:not(:last-child) {
  margin-bottom: 16px;
}

.ac-header {
  width: 100%;
  border: 1px solid rgba(119, 119, 119, 0.5);
  background: #FFFFFF;
}

.ac .ac-trigger {
  padding: 20px;
  color: #192A32;
  font-family: "Poppins", sans-serif;
  font-size: 16px;
  font-weight: 600;
  line-height: 24px;
  text-transform: uppercase;
}

.ac .ac-trigger:focus {
  color: #192A32;
}

.ac .ac-panel {
  padding: 0 12px;
  color: #192A32;
  font-family: "Poppins", sans-serif;
  font-size: 16px;
  font-weight: 400;
  line-height: 24px;
  background: rgb(223, 232, 246);
  border-radius: 0 0 6px 6px;
}

.ac.is-active .ac-panel {
  padding: 16px 12px;
}

.ac .ac-trigger::after {
  content: url("../img/arr-down.svg");
  width: 24px;
  height: 24px;
  flex-shrink: 0;
  -webkit-transform: translate(0, -50%);
  transform: translate(0, -50%);
  position: absolute;
  right: 20px;
  top: 50%;
}

.ac.is-active > .ac-header .ac-trigger::after {
  content: url("../img/arr-up.svg");
  width: 24px;
  height: 24px;
}

.header {
  background-color: #192A32;
  position: fixed;
  top: 0;
  left: 0;
  right: 0;
  z-index: 10;
  padding: 16px 0;
}
.header__container {
  display: flex;
  justify-content: space-between;
  align-items: center;
  max-width: 1240px;
  margin: 0 auto;
}
.header__box {
  display: flex;
  align-items: center;
  gap: 28px;
}
.header__logo {
  padding: 14.5px 32px;
  display: flex;
  align-items: center;
  justify-content: center;
  color: #FFFFFF;
  background-color: #141E55;
  font-size: 20px;
  line-height: 25.6px;
  text-transform: uppercase;
}
.header__nav-list {
  display: flex;
  align-items: center;
  gap: 21px;
}
.header__nav-link {
  color: #FCFCFC;
  font-size: 16px;
  line-height: 20.5px;
  padding: 12px 24px;
  font-weight: 600;
  display: flex;
  align-items: center;
  gap: 10px;
  background-color: #1A3769;
  border-radius: 16px;
}
.header__button {
  font-size: 16px;
  line-height: 20.5px;
  font-weight: 600;
  padding: 14px 32px;
  border-radius: 16px;
  border: none;
  outline: none;
  color: #FCFCFC;
  text-transform: uppercase;
  transition: all 0.3s ease;
}
.header__button--green {
  background-color: #0FA810;
}
.header__button--orange {
  background-color: #EC622B;
}
.header__button:hover {
  background-color: #141E55;
}
.header__language-options.hidden {
  display: none;
  opacity: 0;
  visibility: hidden;
}
.header__actions {
  display: flex;
  align-items: center;
  gap: 16px;
}

.mobile-app {
  padding: 25px 20px;
  background-color: #FFFFFF;
  border-radius: 6px;
}
.mobile-app__content {
  display: flex;
  align-items: center;
  justify-content: space-between;
  gap: 40px;
}
.mobile-app__button {
  display: inline-flex;
  align-items: center;
  gap: 7px;
  background-color: #1A3769;
  font-weight: 600;
  font-size: 16px;
  line-height: 19.2px;
  flex-shrink: 0;
  border-radius: 16px;
  padding: 12px;
  text-transform: uppercase;
  color: #FFFFFF;
  transition: all 0.3s ease;
}
.mobile-app__text {
  max-width: 666px;
}

.hero {
  padding: 41px 20px 52px;
  position: relative;
  border-radius: 6px;
}
.hero__img {
  position: absolute;
  bottom: 0;
  left: 0;
  right: 0;
  width: 100%;
  height: 100%;
  object-fit: cover;
  object-position: center;
  border-radius: 6px;
}
.hero__rating {
  position: relative;
  display: flex;
  align-items: center;
  gap: 8px;
  margin-bottom: 38px;
}
.hero__rating-text {
  font-weight: 600;
  font-size: 24px;
  line-height: 29px;
  color: #FFFFFF;
}
.hero__rating-icon {
  width: 144px;
}
.hero__title {
  font-weight: 700;
  font-size: 40px;
  line-height: 48px;
  color: #FFFFFF;
  max-width: 538px;
  margin-bottom: 16px;
  position: relative;
}
.hero__text {
  font-size: 6px;
  line-height: 9px;
  color: #FFFFFF;
  text-align: center;
  margin-top: 10px;
}
.hero__action {
  max-width: 214px;
  position: relative;
}

.bonus {
  padding: 90px 20px;
  position: relative;
  border-radius: 6px;
}
.bonus__img {
  position: absolute;
  bottom: 0;
  left: 0;
  right: 0;
  width: 100%;
  height: 100%;
  object-fit: cover;
  object-position: center;
  border-radius: 6px;
}
.bonus__info {
  position: relative;
}
.bonus__title {
  font-weight: 700;
  font-size: 40px;
  line-height: 48px;
  color: #192A32;
  margin-bottom: 16px;
  position: relative;
}
.bonus__text {
  font-size: 32px;
  line-height: 38.4px;
  font-weight: 700;
  color: #192A32;
  max-width: 494px;
  margin-bottom: 16px;
}

.up {
  padding: 32px 20px;
  background-color: #FFFFFF;
  border-radius: 6px;
}
.up__title {
  font-weight: 700;
  font-size: 48px;
  line-height: 57.6px;
  color: #192A32;
  margin-bottom: 16px;
}
.up__text {
  font-size: 16px;
  line-height: 24px;
  color: #192A32;
}

.rating {
  padding: 32px 20px;
  background-color: #FFFFFF;
  border-radius: 6px;
}
.rating__list {
  display: flex;
  flex-direction: column;
  gap: 10px;
  width: 100%;
}
.rating__item {
  display: flex;
  align-items: center;
  justify-content: space-between;
  gap: 40px;
  background-color: #80BEF8;
  padding: 16px 20px 16px 24px;
  border-radius: 6px;
}
.rating__item-text {
  font-size: 16px;
  line-height: 24px;
  color: #FFFFFF;
  font-weight: 600;
  text-transform: uppercase;
}
.rating__item-box {
  display: flex;
  align-items: center;
  gap: 16px;
}
.rating__item-box-text {
  font-size: 14px;
  line-height: 21px;
  color: #FFFFFF;
}

.facts {
  padding: 32px 55px 24px 20px;
  background-color: #FFFFFF;
  border-radius: 6px;
}
.facts__title {
  font-weight: 700;
  font-size: 40px;
  line-height: 48px;
  color: #192A32;
  margin-bottom: 18px;
  text-transform: uppercase;
  margin-left: 20px;
  position: relative;
  max-width: 269px;
}
.facts__title::after {
  content: "";
  display: block;
  width: 100%;
  height: 2px;
  background-color: #C5C5C5;
}
.facts__list {
  display: flex;
  flex-direction: column;
  gap: 10px;
}
.facts__item {
  display: flex;
  align-items: center;
  gap: 32px;
  padding: 8px 16px;
  border-bottom: 1px solid rgba(119, 119, 119, 0.5);
}
.facts__item-left {
  min-width: 199px;
  display: flex;
  gap: 8px;
  align-items: center;
  font-weight: 500;
  font-size: 16px;
  line-height: 24px;
  color: #192A32;
}
.facts__item-right {
  font-size: 16px;
  line-height: 24px;
  color: #192A32;
}

.reviews {
  padding: 32px 20px;
  background-color: #FFFFFF;
  border-radius: 6px;
}
.reviews__title {
  font-weight: 700;
  font-size: 48px;
  line-height: 57.6px;
  color: #192A32;
  margin-bottom: 24px;
  text-transform: uppercase;
}
.reviews__text {
  margin-bottom: 20px;
}
.reviews__text--mbm {
  margin-bottom: 24px;
}
.reviews__text--mbl {
  margin-bottom: 32px;
}
.reviews__subtitle {
  font-weight: 700;
  font-size: 40px;
  line-height: 48px;
  color: #192A32;
  margin-bottom: 24px;
  margin-top: 40px;
  text-transform: uppercase;
}
.reviews__mark-list {
  display: flex;
  flex-direction: column;
  gap: 24px;
  margin-bottom: 24px;
}
.reviews__mark-list-item {
  position: relative;
  padding-left: 31px;
}
.reviews__mark-list-item::before {
  content: "-";
  width: 23px;
  height: 24px;
  display: flex;
  align-items: center;
  justify-content: center;
  position: absolute;
  left: 0;
}
.reviews__number-list {
  display: flex;
  flex-direction: column;
  counter-reset: custom-counter;
  gap: 24px;
}
.reviews__number-list-item {
  position: relative;
  padding-left: 31px;
}
.reviews__number-list-item::before {
  content: counter(custom-counter);
  counter-increment: custom-counter;
  width: 23px;
  height: 24px;
  display: flex;
  align-items: center;
  justify-content: center;
  position: absolute;
  left: 0;
  font-size: 16px;
  line-height: 24px;
  color: #0FA810;
}

.faq {
  padding: 30px 20px;
  background-color: #FFFFFF;
  border-radius: 6px;
}
.faq__title {
  font-weight: 700;
  font-size: 48px;
  line-height: 57.6px;
  color: #192A32;
  margin-bottom: 32px;
  margin-left: 7px;
  text-transform: uppercase;
}

/*# sourceMappingURL=main.cs.map */
