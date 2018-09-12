# SpotifyAuthBinding

Replace "ClientID" and "RedirectUrl"

```
private void HandleLoginSpotify()
{
    AuthenticationRequest.Builder builder = new AuthenticationRequest.Builder("ClientID", AuthenticationResponse.Type.Token, "RedirectUrl");
            builder.SetScopes(new string[] { "user-read-private", "streaming", "user-library-read", "user-library-modify" });
    AuthenticationRequest request = builder.Build();
    int requestCode = 9999;
    AuthenticationClient.OpenLoginActivity(this, requestCode, request);
}
```

```
protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
{
            base.OnActivityResult(requestCode, resultCode, data);
            if (requestCode == 9999)
            {
                AuthenticationResponse response = AuthenticationClient.GetResponse((int)resultCode, data);
                var type = response.GetType();
                var token = AuthenticationResponse.Type.Token;
                if (response.GetType() == AuthenticationResponse.Type.Token)
                {
                    Config playerConfig = new Config(this, response.AccessToken, "ClientID");
                    //Create player
                }
                else
                {
                    //Error
                }
            }
}
```
