# This modified explanation is from [ev3nvy](https://github.com/ev3nvy)

Since the riot client now supports 2FA the auth flow is somewhat different for users with enabled 2FA
After the PUT request to  https://auth.riotgames.com/api/v1/authorization :

```
{
    "type": "auth",
    "username": "username",
    "password": "password"
}
```

The response looks like this if 2FA is enabled:
```
{
    "type": "multifactor",
    "multifactor": {
        "email": "abc**@****.com",
        "method": "email",
        "methods": [
            "email"
        ],
        "multiFactorCodeLength": 6,
        "mfaVersion": "v2"
    },
    "country": "", // country code that they use everywhere
    "securityProfile": "low"
}
```


Best way to now check if 2FA is required is to look at the type field. (multifactor if 2FA is required and response if we actually got access token as a response).

This makes it more annoying for us but it's a security feature so it's fine.

After that response we need to send the 2FA code to the riot servers like this:

PUT https://auth.riotgames.com/api/v1/authorization

```
{
    "type": "multifactor",
    "code": "", // 2FA code here
    "rememberDevice": true
}
```