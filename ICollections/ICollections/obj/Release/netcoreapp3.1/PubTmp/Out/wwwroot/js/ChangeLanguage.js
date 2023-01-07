const select = document.querySelector('select');
const allLang = ['en', 'ru'];

const langArr = {
    "Login": {
        "en": "Login",
        "ru": "Логин",
    },
    "Email": {
        "en": "Email",
        "ru": "Почта",
    },
    "Password": {
        "en": "Password",
        "ru": "Пароль",
    },
    "PassConfirm": {
        "en": "Password Confirm",
        "ru": "Подтверждение Пароля",
    },
    "Catalog": {
        "en": "Catalog",
        "ru": "Каталог",
    },
    "Switch": {
        "en": "Switch Theme",
        "ru": "Сменить тему",
    },
    "Image": {
        "en": "Image",
        "ru": "Изображение",
    },
    "Item": {
        "en": "Item Name",
        "ru": "Название Коллекции",
    },
    "Tag": {
        "en": "Item Tag",
        "ru": "Тэг",
    },
    "Desc": {
        "en": "Item Description",
        "ru": "Описание",
    },
    "Close": {
        "en": "Close",
        "ru": "Закрыть",
    },

    "Upload": {
        "en": "Upload Image",
        "ru": "Загрузить Изображение",
    },
    "Add": {
        "en": "Add Custom Field",
        "ru": "Добавить Кастомное Поле",
    },
    "Create": {
        "en": "Create New Item",
        "ru": "Создать Новую Коллекцию",
    },
    "AdminMenu": {
        "en": "Admin Menu",
        "ru": "Панель Администратора",
    },
    "Profile": {
        "en": "Profile",
        "ru": "Профиль",
    },
    "signOut": {
        "en": "Sign Out",
        "ru": "Выход",
    },
    "Largest": {
        "en": "Largest Collections",
        "ru": "Самые Большие Коллекции",
    },
    "signIn": {
        "en": "Sign In",
        "ru": "Вход"
    },
    "Register": {
        "en": "Register",
        "ru": "Регистрация",
    },
    "Likes": {
        "en": "Likes",
        "ru": "Понравилось",
    },
    "Admin": {
        "en": "Admin",
        "ru": "Администратор"
    },
    "User": {
        "en": "User",
        "ru": "Пользователь",
    },
    "userName": {
        "en": "User Name",
        "ru": "Имя Пользователя",
    },
    "Status": {
        "en": "Status",
        "ru": "Статус",
    },
    "Role": {
        "en": "Role",
        "ru": "Роль",
    },
    "Action": {
        "en": "Action",
        "ru": "Действие",
    },
    "Comment": {
        "en": "Comment",
        "ru": "Комментарии",
    },
    "CreateCollection": {
        "en": "Create",
        "ru": "Создать",
    },
    "Update": {
        "en": "Update",
        "ru": "Обновить",
    },
    "Delete": {
        "en": "Delete",
        "ru": "Удалить",
    },
    "Import": {
        "en": "Import",
        "ru": "Импорт",
    },
    "Download": {
        "en": "Download",
        "ru": "Загрузить",
    },
    "Search": {
        "en": "Search",
        "ru": "Поиск",
    },
    "addTo": {
        "en": "Add to:",
        "ru": "Добавить в:",
    },
    "NotBlckd": {
        "en": "Not Blocked",
        "ru": "Не Заблокирован",
    },
    "CreateItm": {
        "en": "Create Item",
        "ru": "Создать Коллекцию",
    },
    "UpdateItm": {
        "en": "Update Item",
        "ru": "Обновить Коллекцию",
    },
    "DeleteItm": {
        "en": "Delete Item",
        "ru": "Удалить Коллекцию",
    },
    "Tools": {
        "en": "Collection Tools:",
        "ru": "Взаимодействие С Коллекциями:",
    },
    "BlockUser": {
        "en": "Block",
        "ru": "Заблокировать",
    },
    "SetAdmin": {
        "en": "Set Admin Role",
        "ru": "Назначить Админом",
    },
    "UnblockUser": {
        "en": "Unblock",
        "ru": "Разблокировать",
    },
    "SetUserRole": {
        "en": "Set User Role",
        "ru": "Назначить Юзером",
    },
    "NotBlocked": {
        "en": "Not Blocked",
        "ru": "Не Заблокирован",
    },
    "Blocked": {
        "en": "Blocked",
        "ru": "Заблокирован",
    },
    "ItemsHeader": {
        "en": "Items",
        "ru": "Коллекции",
    },
    "TagCloud": {
        "en": "Tag Cloud",
        "ru": "Облако Тегов",
    },
    "UploadImage": {
        "en": "Upload Image",
        "ru": "Загрузить изображение",
    },
}
select.addEventListener('change', changeURLLanguage);

function changeURLLanguage() {
    let lang = select.value;
    localStorage.setItem('lang', lang);
    location.href = window.location.pathname + "#" + lang;
    location.reload();
}

function changeLanguage() {
    let lang = localStorage.getItem('lang');
    if (!allLang.includes(lang)) {
        location.href = window.location.pathname + '#en';
        lang = "en";
        localStorage.setItem('lang', lang);
    }

    location.href = window.location.pathname + "#" + lang;
    select.value = lang;
    for (let key in langArr) {
        let elem = document.querySelectorAll(".lng-" + key);
        if (elem) {
            elem.forEach(element => element.innerHTML = langArr[key][lang]);
        }
    }
}

function getCurrentLanguage() {
    return window.location.hash.substring(1);
}

changeLanguage();